using System;
using System.IO;
using System.Text;


string[] names = { "Lilith Nakamura", "Julia Daniels" };
string[] overview = 
    {
"https://app.notion.com/p/Lilith-Overview-4096a2c25cab809f90f0fc38ec0040d0?source=copy_link" ,
"https://app.notion.com/p/Julia-Overview-4136a2c25cab80a9bcedd23fdbc81e51?source=copy_link"
      };

string[] Sypnosis = 
    {
"https://app.notion.com/p/Lilith-Synopsis-4136a2c25cab80fba8e3ff527b896a7c?source=copy_link",
"https://app.notion.com/p/Julia-Synopsis-4136a2c25cab80498cf2ff506e326439?source=copy_link"
};
StringBuilder HTML = new StringBuilder();
HTML.AppendLine("<!DOCTYPE html>");
HTML.AppendLine("<html>");
HTML.AppendLine("<head>");
HTML.AppendLine("<link rel=\"stylesheet\" href=\"style.css\">");
HTML.AppendLine("</head>");
HTML.AppendLine("<body>");
for (int i = 0; i < names.Length; i++)
{
    HTML.AppendLine("<h2>" + names[i] + "</h2>");
    HTML.AppendLine("<div class=\"tabs\">");

    HTML.AppendLine("<a class=\"tablinks\" href = \" " + overview[i] + "\" target=\"_blank\" > Overview</a>");

    HTML.AppendLine("<a class= \"tablinks\" href=\"" + Sypnosis[i] + "\" target= \"_blank\">Sypnosis</a>");


    HTML.AppendLine("</div>");
}

HTML.AppendLine("</body>");
HTML.AppendLine("</html>");

File.WriteAllText("../../../index.html", HTML.ToString());