using System;
string CalculatorWarning(int pointNumber)
{
    string alertstring = "";
    if (pointNumber == 0)
    {
        alertstring += "NO WAENING!";
    }
    else if (pointNumber >= 1 && pointNumber <= 5)
    {
        alertstring += "WARNING!!!";
    }

    else if (pointNumber >= 6 && pointNumber <= 10)
    {
        alertstring += "DANGER!!!";
    }
    else if (pointNumber >= 11 && pointNumber <= 15)
    {
        alertstring += "ULTRA ALERT!!!";
    }
    else
    {
        alertstring += "ERROR!!!";
    }
    return alertstring;
}