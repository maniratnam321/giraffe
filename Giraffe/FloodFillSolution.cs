namespace Giraffe
{
    class FloodFillSolution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if(image != null && image[sr][sc] != newColor)
                FloodFill(image, sr, sc, newColor, image[sr][sc]);
            return image;
        }

        public void FloodFill(int[][] image, int sr, int sc, int newColor, int oldColor)
        {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[sr].Length) 
            {
                return;
            }
            if (image[sr][sc] == oldColor) 
            {
                image[sr][sc] = newColor;
                FloodFill(image, sr + 1, sc, newColor, oldColor);
                FloodFill(image, sr - 1, sc, newColor, oldColor);
                FloodFill(image, sr, sc + 1, newColor, oldColor);
                FloodFill(image, sr, sc - 1, newColor, oldColor);
            }
        }
    }
}
