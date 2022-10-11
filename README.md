# CodeLib
A really old attempts in cryptography (date ~2015)

# How to use
But for what?

Oh, ok:

## Encode
Use ```class Code``` to encode ```string```
```
Code.tabs(string input, int firsttab, int endtab, bool time);
```
```input``` - is your input

```firsttab``` and ```endtab``` are integers from ```1``` to ```5``` to use exact coding table (same have to be while decoding)

```time``` have to be ```false```

## Decode
Use ```class Decode``` to encode ```string```
```
Decode.tabs(string input, int firsttab, int endtab, bool time);
```
```input``` - is your input, ```firsttab``` and ```endtab``` are your values from Encode stage

>2 3
>HwgHОgXсgXсgwgiRхiwgXwgiigHwgXiхXHgXсgXHgiigHwgОхXgXbgXigiиgXхwgibgXсgсgHсхbgbЦgXЦgОgiRхОgiЦgXigiwgЦхсgXОgXHgHwgXigiigiRхОgXОgbЦgbЦgiHgXх
