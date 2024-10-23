public class ChartInputData
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public double Z { get; private set; }

    public bool TryParseInput(string xInput, string yInput, string zInput)
    {
        // Parse input strings to doubles and ensure they are non-negative
        bool xValid = double.TryParse(xInput, out double x) && x >= 0;
        bool yValid = double.TryParse(yInput, out double y) && y >= 0;
        bool zValid = double.TryParse(zInput, out double z) && z >= 0;

        if (xValid && yValid && zValid)
        {
            X = x; // Assign parsed value to X
            Y = y; // Assign parsed value to Y
            Z = z; // Assign parsed value to Z
            return true; // Parsing succeeded
        }

        return false; // Parsing failed
    }
}
