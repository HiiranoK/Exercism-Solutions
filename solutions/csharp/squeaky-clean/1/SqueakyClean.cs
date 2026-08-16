using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        bool capitalizeNext = false;
        foreach (char c in identifier){
            if(c == ' '){
                sb.Append('_');
            }
            else if( char.IsControl(c)){
                sb.Append("CTRL");
            }
            else if( char.IsLetter(c)){
                if(c >= 'α' && c <= 'ω'){
                    continue;
                }
                if(capitalizeNext){
                    capitalizeNext = false;
                    char b = char.ToUpper(c);
                    sb.Append(b);
                    continue;
                }
                sb.Append(c);
            }
            else if(c == '-'){
                capitalizeNext = true;
            }
            else {
                continue;
            }
        }
        return sb.ToString();
    }
}
