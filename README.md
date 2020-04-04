# SudoC
Programming Language for retards, written mainly by me(other people are for comidec purposes only).
Converts easy and understandable syntax to very hard but effeicient C.

# Examples
1. Auto Created Variables :
```python
print("Name:")
var Name = input<>;
print("Hello 'Name'!")
print("\n That is a cool name though 'Name'")
```
in the example above we use
```python
var Name = input<>;
``` to create a variable but that's not needed in SudoC. You can write
```python
print("Name:")
print("Hello 'input<Name>'!")
print("\n That is a cool name though 'Name'")
```
they both have the same C output:
```c
printf("Name:");
char Name[2056];
scanf("%s",Name);
printf("Hello ");
printf("%s", Name);
printf("!");
printf("\n That is a cool name though ");
printf("%s", Name);
```
