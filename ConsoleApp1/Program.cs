int[] score = new int[5];

for (int i = 0; i < score.Length; i++)
{
    Console.Write("학생" + (i+1) + "의 성적 입력: ");
    score[i] = int.Parse(Console.ReadLine());
    
}

int sum = 0;
for (int i = 0; i < score.Length; i++)
{
    sum += score[i];
}

double average = (double)sum / score.Length;
Console.WriteLine(average);