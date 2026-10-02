using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder palavra = new StringBuilder();
        bool upper = false;

        foreach(char letra in identifier)
        {
            if(char.IsControl(letra))
            {
                palavra.Append("CTRL");
            }

            else if(letra == ' ')
            {
                palavra.Append('_');
            }

            else if(letra == '-')
            {
                upper = true;
                continue;
            }

            else if(!char.IsLetter(letra) || (letra >= 'α' && letra <= 'ω'))
            {
                continue;
            }

            else if(upper == true)
            {
                palavra.Append(char.ToUpper(letra));
                upper = false;
            }

            else
            {   
                palavra.Append(letra);
            }
        }

        return palavra.ToString();
    }
}
