using System.Runtime.InteropServices;

namespace Lab6
{
    
    public partial class Form1 : Form
    {
        MyArray array;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Win32.MessageBox(0, "текст", "описание", 0);
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (array == null)
                {
                    array = new MyArray((int)sizeOfArray.Value);
                }
                else
                {
                    array = array.Copy((int)sizeOfArray.Value);
                }
            }
            catch (ArrayException arrayException)
            {
                Win32.MessageBox(0, arrayException.Message, "Исключение", 0);
            }
        }

        private void usingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (array == null)
                {
                    throw new ArrayException("массив не инициализирован");
                }
                array[(int)indexOfArrayOnUsing.Value] = (int)number.Value;
            }
            catch (ArrayException arrayException)
            {
                Win32.MessageBox(0, arrayException.Message, "Исключение", 0);
            }
        }
    }
    class Win32
    {
        [DllImport("user32")]
        public static extern int MessageBox(int hwnd, string text, string caption, uint type);
    }
}