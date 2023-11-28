merge(list, left, mid, right): 

i←left;
j←mid+1;
k←left;
while i≤ mid and j≤right do
	if(list[i]< list[j]) 
		then
          sorted[k]←list[i] ;
k++;
i++;

        else
    sorted[k]←list[j];
k++;
j++;

요소가 남아있는 부분배열을 sorted로 복사한다;
sorted를 list로 복사한다;

int sorted[MAX_SIZE];

void merge(int list[], int left, int mid, int right)
{
    int i, j, k, l;
    i = left; j = mid + 1; k = left;
    while (i <= mid && j <= right)
    {
        if (list[i] <= list[j]) sorted[k++] = list[i++];
        else sorted[k++] = list[j++];
    }

if (i > mid)
        for (l = j; l <= right; l++)
            sorted[k++] = list[l];
    else
        for (l = i; l <= mid; l++)
            sorted[k++] = list[l];
    for (l = left; l <= right; l++)
        list[l] = sorted[l];
}

void merge_sort(int list[], int left, int right)
{
    int mid;
    if (left < right)
    {
        mid = (left + right) / 2;
        merge_sort(list, left, mid);
        merge_sort(list, mid + 1, right);
        merge(list, left, mid, right);
    }
}