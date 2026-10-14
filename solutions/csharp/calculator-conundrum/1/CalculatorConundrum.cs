public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {

        if (operation == null)
        {
            throw new ArgumentNullException();
        }


        else if (string.IsNullOrEmpty(operation))
        {
            throw new ArgumentException();
        }

        else if (operation != "+" && operation != "*" && operation != "/")
        {
            throw new ArgumentOutOfRangeException();
        }

        else if(operation == "/" && operand2 == 0)
        {
            return "Division by zero is not allowed.";
        }


        else if (operation == "+")
        {
            return ($"{operand1} + {operand2} = {(operand1 + operand2)}");
        }

        else if (operation == "*")
        {
            return ($"{operand1} * {operand2} = {(operand1 * operand2)}");
        }

        else if (operation == "/")
        {
            return ($"{operand1} / {operand2} = {(operand1 / operand2)}");
        }

        return operation;

    }
}
