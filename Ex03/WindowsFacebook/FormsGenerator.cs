using System;
using System.Windows.Forms;

namespace WindowsFacebook
{
    public static class FormsGenerator
    {
        internal static Form GenerateForm(UIEnums.eFormType i_FormType)
        {
            Form resultForm = null;
            switch (i_FormType)
            {
                case UIEnums.eFormType.MainMenu:
                    if (!checkIfFormOpen(typeof(MainMenuForm)))
                    {
                        resultForm = new MainMenuForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(MainMenuForm));
                    }

                    break;
                case UIEnums.eFormType.Collage:
                    if (!checkIfFormOpen(typeof(CollageForm)))
                    {
                        resultForm = new CollageForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(CollageForm));
                    }

                    break;
                case UIEnums.eFormType.FriendsAlbums:
                    if (!checkIfFormOpen(typeof(FriendsAlbumsForm)))
                    {
                        resultForm = new FriendsAlbumsForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(FriendsAlbumsForm));
                    }

                    break;
                case UIEnums.eFormType.FriendsStatus:
                    if (!checkIfFormOpen(typeof(FriendStatusForm)))
                    {
                        resultForm = new FriendStatusForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(FriendStatusForm));
                    }

                    break;
                case UIEnums.eFormType.Groups:
                    if (!checkIfFormOpen(typeof(GroupsForm)))
                    {
                        resultForm = new GroupsForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(GroupsForm));
                    }

                    break;
                case UIEnums.eFormType.LikedPages:
                    if (!checkIfFormOpen(typeof(LikedPagesForm)))
                    {
                        resultForm = new LikedPagesForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(LikedPagesForm));
                    }

                    break;
                case UIEnums.eFormType.Login:
                    if (!checkIfFormOpen(typeof(LoginForm)))
                    {
                        resultForm = new LoginForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(LoginForm));
                    }

                    break;
                case UIEnums.eFormType.MyAlbums:
                    if (!checkIfFormOpen(typeof(MyAlbumsForm)))
                    {
                        resultForm = new MyAlbumsForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(MyAlbumsForm));
                    }

                    break;
                case UIEnums.eFormType.MyEvents:
                    if (!checkIfFormOpen(typeof(MyEventsForm)))
                    {
                        resultForm = new MyEventsForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(MyEventsForm));
                    }

                    break;
                case UIEnums.eFormType.MyProfile:
                    if (!checkIfFormOpen(typeof(MyProfileForm)))
                    {
                        resultForm = new MyProfileForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(MyProfileForm));
                    }

                    break;
                case UIEnums.eFormType.SoulMate:
                    if (!checkIfFormOpen(typeof(SoulMateForm)))
                    {
                        resultForm = new SoulMateForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(SoulMateForm));
                    }

                    break;
                case UIEnums.eFormType.UserActions:
                    if (!checkIfFormOpen(typeof(UserActionsForm)))
                    {
                        resultForm = new UserActionsForm();
                    }
                    else
                    {
                        resultForm = GetOpenForm(typeof(UserActionsForm));
                    }

                    break;
            }

            return resultForm;
        }

        private static bool checkIfFormOpen(Type i_FormType)
        {
            bool isOpen = false;

            foreach (Form currentForm in Application.OpenForms)
            {
                if (currentForm.GetType().Equals(i_FormType))
                {
                    isOpen = true;
                    break;
                }
            }

            return isOpen;
        }

        public static Form GetOpenForm(Type i_FormType)
        {
            Form form = null;

            foreach (Form currentForm in Application.OpenForms)
            {
                if (currentForm.GetType().Equals(i_FormType))
                {
                    form = currentForm;
                    break;
                }
            }

            return form;
        }
    }
}