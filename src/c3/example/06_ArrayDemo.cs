class ArrayDemo
{
  static void Main()
  {
    const int SCORE_SIZE = 1000;
    int[] scores = new int[SCORE_SIZE];

    for (int i = 0; i < 1000; i++)
    {
      // Console.WriteLine(scores[i]); <-- empty int is inialized to 0
      scores[i] = MethodLibraries.ReadInt("Score: ", 0, 1000);
    }
  }
}