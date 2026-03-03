using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            if (char.IsWhiteSpace(identifier[i]))
                sb.Append('_');
            else if (char.IsControl(identifier[i]))
            {
                sb.Append('C');
                sb.Append('T');
                sb.Append('R');
                sb.Append('L');
            }
            else if (identifier[i] == '-')
            {
                i++;
                sb.Append(char.ToUpper(identifier[i]));
            }
            else if (!char.IsLetter(identifier[i]))
            {

            }
            else if (char.IsBetween(identifier[i], 'α', 'ω'))
            {

            }
            else
            {
                sb.Append(identifier[i]);
            }
        }

        return sb.ToString();
    }
}
