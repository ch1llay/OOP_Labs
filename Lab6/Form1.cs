using System.Runtime.InteropServices;

namespace Lab6
{

    public partial class Form1 : Form
    {
        MyArray<Product> array;

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
                    array = new MyArray<Product>((int)sizeOfArray.Value);
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

        private void usingPutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (array == null)
                {
                    throw new ArrayException("массив не инициализирован");
                }
                int index = (int)indexOfArrayOnUsing.Value;
                array[index] = new Product(index);
            }
            catch (ArrayException arrayException)
            {
                Win32.MessageBox(0, arrayException.Message, "Исключение", 0);
            }
        }

        private void getProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                var el = array[(int)indexOfArrayOnUsing.Value];
                Win32.MessageBox(0, el.ToString(), el.Name, 0);
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