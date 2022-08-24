using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CRUDForm : Form
    {
        INTEC_AGU_OCT22Entities db = new INTEC_AGU_OCT22Entities();
        public CRUDForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetClientTypes();
            GetContactTypes();
            GetPermissions();
            GetRestrictions();
        }

        private void GetRestrictions()
        {
            var restrictions = db.Restrictions.ToList();
            foreach (var item in restrictions)
            {
                cblRestrictions.Items.Add(item.Name);
            }
        }

        private void GetPermissions()
        {
            var permissions = db.Permissions.ToList();
            foreach (var item in permissions)
            {
                cblPermissions.Items.Add(item.Name);
            }
        }

        private void GetClientTypes()
        {
            var clientTypes = db.ClientTypes.ToList();
            cbClientType.DataSource = clientTypes;
            cbClientType.DisplayMember = "Name";
            cbClientType.ValueMember = "Id";
        }

        private void GetContactTypes()
        {
            var contactTypes = db.ContactTypes.ToList();
            cbContactType.DataSource = contactTypes;
            cbContactType.DisplayMember = "Name";
            cbContactType.ValueMember = "Id";
        }
    }
}
