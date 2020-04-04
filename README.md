# SudoC
Programming Language for retards, written mainly by me(other people are for comidec purposes only).
Converts easy and understandable syntax to very hard but effeicient C.
```python
print("Name:")
print("Hello 'input<Name>'!")
```
Converts to
```c
printf("Name:");
char Name[2056];
scanf("%s",Name);
printf("Hello ");
printf("%s", Name);
printf("!");
```
