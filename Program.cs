using System;
using System.IO;
using System.Text;


string[] names = { "Lilith Nakamura", "Julia Daniels" , "Hallon Plaintiffin" };  
string[] overview = 
    {
"https://chief-split-0d9.notion.site/Lilith-Overview-4096a2c25cab809f90f0fc38ec0040d0?pvs=143" ,
"https://chief-split-0d9.notion.site/Julia-Overview-4136a2c25cab80a9bcedd23fdbc81e51?pvs=143" ,
"https://chief-split-0d9.notion.site/Hallon-Overview-41c6a2c25cab80d49d25cc88ff86c6bb"
      };

string[] Sypnosis = 
    {
"https://chief-split-0d9.notion.site/Lilith-Synopsis-4136a2c25cab80fba8e3ff527b896a7c?pvs=143",
"https://chief-split-0d9.notion.site/Lilith-Synopsis-4136a2c25cab80fba8e3ff527b896a7c?pvs=143" ,
"https://chief-split-0d9.notion.site/Hallon-Synopsis-41c6a2c25cab803084a6c76bfdde614d"
};

string[] relationships =
{
    "https://chief-split-0d9.notion.site/Lilith-Relationships-4136a2c25cab800db194e58c03f239d4" ,
    "https://chief-split-0d9.notion.site/Julia-Relationship-4136a2c25cab80549b8ad16604c62a75" ,
    "https://chief-split-0d9.notion.site/Hallon-Relationships-41c6a2c25cab80d5bd17c4c2f95daef4"
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

    HTML.AppendLine("<button onclick=\"showPage('" + overview[i] + "')\"> Overview</button>");

    HTML.AppendLine("<button onclick=\"showPage('" + Sypnosis[i] + "') \">Sypnosis</button>");

    HTML.AppendLine("<button onclick=\"showPage('" + relationships[i] + "')\">Relationships</button>");

    HTML.AppendLine("</div>");

    
}
HTML.AppendLine("<script>");
HTML.AppendLine("function showPage(url) {");
HTML.AppendLine("window.open(url, 'NotionPage', 'width=900, height=700');");
HTML.AppendLine("}");
HTML.AppendLine("</script>");

HTML.AppendLine("</body>");
HTML.AppendLine("</html>");

File.WriteAllText("../../../index.html", HTML.ToString());