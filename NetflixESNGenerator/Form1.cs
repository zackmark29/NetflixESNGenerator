using System;
using System.Windows.Forms;

namespace NetflixESNGenerator {

    public partial class Form1 : Form {

        const string Version = "v1.0.0 | 2022-01-09";
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) {
            txtVersion.Text = Version;
            LoadSample();
            chkAutoGenerate.Checked = true;
            cboDeviceType.SelectedIndex = 0;
            cboDeviceSubType.SelectedIndex = 0;
        }
        void LoadSample() {
            txtDeviceManufacturer.Text = "lenovo";
            txtDeviceModel.Text = "TB-X705L";
            txtDeviceSystemId.Text = "9075";
        }
        void GenerateBrowserESN() {
            EnableButton(true);
            txtESNOutput.Text = DeviceType.Chrome + Utils.RandomString(30);
        }
        void GenerateAndroidESN() {
            EnableButton(true);
            var controls = new[] { txtDeviceManufacturer, txtDeviceModel, txtDeviceSystemId };
            foreach (var control in controls) {
                if (string.IsNullOrEmpty(control.Text)) {
                    ShowMessage(control);
                    return;
                }
            }
            if (InvalidSystemId()) return;

            var esn = chkUHD.Checked ? DeviceType.AndroidUHD : DeviceType.AndroidFHD;
            switch (cboDeviceSubType.Text) {
                case "Phone":   esn += DeviceSubType.AndroidPhone;  break;
                case "Tablet":  esn += DeviceSubType.AndroidTablet; break;
                case "TV":      esn += DeviceSubType.AndroidTV;     break;
            }
            var manufacturer = txtDeviceManufacturer.Text.TakeChar(5).ToUpper();
            var model        = txtDeviceModel.Text.ToUpper().Replace(" ", "=");
            var systemId     = txtDeviceSystemId.Text;
            var rand         = Utils.RandomString(64);
            txtESNOutput.Text = $"{esn}-{manufacturer}{model}-{systemId}-{rand}";
        }

        void Generate() {
            if (cboDeviceType.SelectedIndex == 1) {
                GenerateBrowserESN();
                return;
            }
            GenerateAndroidESN();
        }

        void EnableButton(bool enable) {
            btnCopyEsn.Text = enable ? "Copy ESN" : "Copied";
            btnCopyEsn.Enabled = enable;
        }

        bool InvalidSystemId() {
            if (txtDeviceSystemId.TextLength >= 6) {
                MessageBox.Show(
                    "Invalid System Id format. " +
                    "Length should be less than or equal to 5",
                    "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeviceSystemId.Focus();
                txtDeviceSystemId.SelectAll();
                return true;
            }
            return false;
        }

        void ShowMessage(TextBox txt) {
            MessageBox.Show($"{txt.Name} cannot be empty",
                "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txt.Focus();
        }

        private void btnCopyEsn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtESNOutput.Text)) return;

            Clipboard.SetText(txtESNOutput.Text);
            EnableButton(false);
            txtESNOutput.Focus();
            txtESNOutput.SelectAll();
        }

        private void txtDeviceSystemId_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void TryGenerate() {
            if (cboDeviceType.Text == "Android" && chkAutoGenerate.Checked) GenerateAndroidESN();
        }
        private void chkUHD_CheckedChanged(object sender, EventArgs e) {
            TryGenerate();
        }

        private void cboDeviceSubType_SelectedIndexChanged(object sender, EventArgs e) {
            TryGenerate();
        }

        private void cboDeviceType_SelectedIndexChanged(object sender, EventArgs e) {
            Generate();
        }

        private void txtDeviceManufacturer_TextChanged(object sender, EventArgs e) {
            TryGenerate();
        }

        private void txtDeviceModel_TextChanged(object sender, EventArgs e) {
            TryGenerate();
        }

        private void txtDeviceSystemId_TextChanged(object sender, EventArgs e) {
            TryGenerate();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            Generate();
        }

        private void label6_Click(object sender, EventArgs e) {
            MessageBox.Show("Credit: nyuszika7h for some idea");
        }
    }
}
