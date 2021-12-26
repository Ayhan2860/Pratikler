| [22,27,16,2,18,6] -> Insertion Sort türüne göre aşamaları |
| ------------------------------------------------------------------|
| [22,27,16,2,18,6] |
| [22,27,16,2,18,6] |
| [16,22,27,2,18,6] |
| [2,16,22,27,18,6] |
| [2,16,18,22,27,6] |
| [2,6,16,18,22,27] |

Big-O = O(n^2);

## Time Complexity: 
+ Average case: Aradığımız sayının ortada olması,
+ Worst case: Aradığımız sayının sonda olması, 
+ Best case: Aradığımız sayının dizinin en başında olması. 

## Yukarıda ki bilgilerin durumuna göre; 
#### Dizi sıralandıktan sonra 18 sayısının case kapsamı = Average case;

| [7,3,5,8,2,9,4,15,6]  dizisinin Insertion Sort'a göre ilk 4 adımı |
| ------------------------------------------------------------------|
| [7; 3,5,8,2,9,4,15,6] |
| [3,7; 5,8,2,9,4,15,6] | 
| [3,5,7; 8,2,9,4,15,6] | 
| [3,5,7,8; 2,9,4,15,6] | 

