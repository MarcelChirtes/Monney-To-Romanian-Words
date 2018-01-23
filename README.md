# Monney-To-Romanian-Words

Is a tool that transforms doubles numbers in romanian words, check verbiage before using it, have fun :)

### Ussage
Converts double to with romaninan monney words:

```sh
double monney = 1100.22; 
string result = monney.NumRomaninanMonneyWords();
```

### Results

| Input | Result |
| ------ | ------ |
|1100,22 | o mie o suta lei virgula douazeci si doi bani|
|31433200,222 | treizeci si unu milioane, patru sute treizeci si trei mii, doua sute lei virgula douazeci si doi bani|
|113222100,12 | o suta treisprezece milioane, doua sute douazeci si doi mii, o suta lei virgula doisprezece bani|
|1100323222,122 | unu bilion, o suta milioane, trei sute douazeci si trei mii, doua sute douazeci si doi lei virgula doisprezece bani|
|1100,22 | o mie o suta lei virgula douazeci si doi bani|
|346789 | trei sute patruzeci si sase mii, sapte sute optzeci si noua lei|
|9999991,29 | noua milioane, noua sute nouazeci si noua mii, noua sute nouazeci si unu lei virgula douazeci si opt bani|
|1999991,29 | unu milion, noua sute nouazeci si noua mii, noua sute nouazeci si unu lei virgula douazeci si noua bani|
|1922,23 | o mie noua sute douazeci si doi lei virgula douazeci si trei bani|