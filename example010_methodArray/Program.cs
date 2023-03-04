int[] array = {15,62,74,58,6,68,1,48,59,69,98};

int n = array.Length;
int find = 1;
int index = 0;

while (index < n){
    if (array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}
