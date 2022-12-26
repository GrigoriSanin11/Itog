String [] znach= new string [7] {"sadf", "adadfs", "afafds","afsdgwe","wfwevs","ar","a"};
String [] znach1= new string [znach.Length];


void main (string znach, string znach1)
{
    int count = 0;
     for (int i = 0; i < znach.Length; i++)
    {
        if (znach.Length <= 3 )
            {
                znach[i] = znach1[count];
                count++;

            }
    }



}
