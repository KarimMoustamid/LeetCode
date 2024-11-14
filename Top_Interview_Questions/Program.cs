// See https://aka.ms/new-console-template for more information

using Top_Interview_Questions.Array_Strings.Container_With_Most_Water;
int[] height = {1, 8, 6, 2, 5, 4, 8, 3, 7};
ContainerWithMostWater solution = new ContainerWithMostWater();

int maxWater = solution.MaxArea(height);

Console.WriteLine("The maximum amount of water the container can store is: " + maxWater);