using System.Windows.Forms;

namespace SpineHelper
{
    public class WindowManager
    {
        public static readonly WindowManager instance = new WindowManager();
        
        static WindowManager()
        {
        }

        private WindowManager()
        {
        }


        public Form TryOpen<T>() where T : Form, new()
        {
            bool isOpen = false;

            Form form = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f is T)
                {
                    form = f;
                    isOpen = true;
                }
            }

            if (form != null && isOpen)
            {
                form.BringToFront();
            }
            else
            {
                form = new T();
                form.Show();
            }
            return form;
        }


        /*
        public void TryClose<T>(T form) where T : Form
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is T)
                    isOpen = true;
            }

            if (form != null && isOpen)
            {
                form.Close();
            }
        }
        */
    }

}
