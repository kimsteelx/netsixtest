namespace SX.SB.Lam.Quote
{
    public class HtmlTemplate
    { 
        public string Render(object values, string _html)
        {
            string output = _html;
            foreach (var p in values.GetType().GetProperties())
                output = output.Replace("{{" + p.Name + "}}", (p.GetValue(values, null) as string) ?? string.Empty);
            return output;
        }
    }
}