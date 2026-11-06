using System;
using System.IO;
using System.Windows.Forms;


using System;
using System.IO;
using System.Windows.Forms;
using Xceed.Words.NET;

class Program
{
    [STAThread]
    static void Main()
    {
        OpenFileDialog dialog = new OpenFileDialog();

        dialog.Title = "Select a Word Document";
        dialog.Filter = "Word Documents (*.docx)|*.docx";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = dialog.FileName;

            Console.WriteLine("Word document imported!");
            Console.WriteLine("File: " + filePath);

          
            using (DocX document = DocX.Load(filePath))
            {
                string text = document.Text;

                Console.WriteLine("\n--- Document Content ---\n");
                Console.WriteLine(text);
              
            }
        }
      
        Console.ReadKey();
    }
}
