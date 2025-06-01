namespace Portfolio.Shared
{
    public class ViewportConverter
    {
        public static double VminToPx(double vmin, double width, double height)
        {
            double minDimension = Math.Min(width, height);

            return (vmin * minDimension) / 100.0f;
        }
    }
}
