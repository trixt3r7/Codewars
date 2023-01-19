namespace CodeWars.LevelFive;

// Three 1's => 1000 points
// Three 6's =>  600 points
// Three 5's =>  500 points
// Three 4's =>  400 points
// Three 3's =>  300 points
// Three 2's =>  200 points
// One   1   =>  100 points
// One   5   =>   50 point

public class GreedIsGood
{
  public static int Score(int[] dice)
  {
    int[] tripleScore = { 0, 1000, 200, 300, 400, 500, 600 };
    int[] singleScore = { 0, 100, 0, 0, 0, 50, 0 };

    int score = 0;
    for (int side = 1; side <= 6; side++)
    {
      int count = dice.Where(num => num == side).Count();
      score += tripleScore[side] * (count / 3) + singleScore[side] * (count % 3);
    }
    return score;
  }

  public static int ScoreV1(int[] dice)
  {    
    int score = 0;
    var diceSides = dice.GroupBy(side => side);    

    foreach (var side in diceSides)
    {
      int count = side.Count();
      switch (side.Key)
      {        
        case 1:          
          while (count > 0)
          {
            if (count >= 3)
            {
              score += 1000;
              count -= 3;
            }
            else
            {
              score += 100;
              count -= 1;
            }
          }          
          break;
        case 2:
          if (count >= 3)
          {
            score += 200;
          }
          break;
        case 3:
          if (count >= 3)
          {
            score += 300;
          }
          break;
        case 4:
          if (count >= 3)
          {
            score += 400;
          }
          break;
        case 5:
          while (count > 0)
          {
            if (count >= 3)
            {
              score += 500;
              count -= 3;
            }
            else
            {
              score += 50;
              count -= 1;
            }
          }
          break;
        case 6:
          if (count >= 3)
          {
            score += 600;
          }
          break;
        default:
          break;
      }

    }
    return score;
  }
}
