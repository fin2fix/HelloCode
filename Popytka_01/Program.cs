// Trying to do the task myself

int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friends = 2;
int time = 0;


while (distance > 10)
{
  if (friends == 1)
  {
    time = distance / (firstFriendSpeed + dogSpeed);
    friends = 2;
  }
  else
  {
    time = distance / (secondFriendSpeed + dogSpeed);
    friends = 1;
  }
  distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
  count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз.");
