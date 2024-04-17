using HRMngt._Repository.HR;
using HRMngt.Model;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using HRMngt.Views.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class HRPresenter
    {
        private IHRView view;
        private IHRRepository repository;
        private IEnumerable<UserModel> recuitList;
        private HRDialog dialog;

        public HRPresenter(IHRView view, IHRRepository repository)
        {
            this.view = view;
            this.repository = repository;


            this.view.LoadHRToAdd += LoadHRToAddRecuit;
            
            LoadAllRecuit();
            this.view.ShowHRList(recuitList);
            this.view.Show();
        }

        private void LoadAllRecuit()
        {
            recuitList = repository.GetAll();
        }

        private void LoadHRToAddRecuit(object sender, EventArgs e)
        {
            dialog = this.view.ShowDialogToAdd();
            dialog.LoadAddDialogHR += AddRecuit;
            dialog.ShowDialog();
        }

        private void AddRecuit(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.Name = dialog.NameCadidate;
            user.Email = dialog.Email;
            user.Phone = dialog.Phone;
            user.Address = dialog.Address;
            user.Birthday = dialog.Birthday;
            user.Note = dialog.Note;
            user.Sex = dialog.Sex;
            user.Status = dialog.Status;
            user.Position = dialog.Position;
            user.Contract_type = dialog.Contract_type;
            user.Roles = dialog.Roles;
            repository.Add(user);
            this.dialog.Close();
            LoadAllRecuit();
            view.ShowHRList(recuitList);
            SucessPopUp.ShowPopUp();
        }
    }
}
