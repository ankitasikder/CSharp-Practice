using System;

class Game_Segments_Player{


    public static int score(int [] Arr, int k, int n)
    {
        int sum=0;
        for(int i=k-1;i<n;i++)
        {
            if(Arr[i] == 1)
            {
                sum++;
            }
            else{
                sum--;
            }
        }
        return sum;
    }
    public static int score(int [] Arr, int i)
    {
        if(i==0)
        {
            return 0;
        }
        else
        {
            int sum=0;
            for(int j=0;j<i;i++)
            {
                if(Arr[j] == 1)
                {
                    sum++;
                }
                else{
                    sum--;
                }
            }
            return sum;
        }

    }

    public static void minimumGame(int [] arr, int n)
    {
        int player1, player2;
        for(int i=0;i<n;i++)
        {

            player1 = score(arr,i);
            player2 = score(arr,i+1,n);
            if(player1>player2)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
    public static void main(String[] args){

        int[] arr = {1,1,0,1};
        int n=arr.Length;
        minimumGame(arr,n);
    }
}