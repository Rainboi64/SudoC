# SudoC
Programming Language for idiots, written mainly by me(other people are for comidec purposes only).
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
```
to create a variable but that's not needed in SudoC. You can write

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
The variable creator system is smart. It knows when it should create the variable and when it shouldn't
```python
print("Name:")
print("Hello 'input<Variable>'!")
print("\nThat is a cool name though 'Variable'")
print("\nHow Old Are You 'Variable'?!:")
print("\nWow 'input<Variable>'!")
```
To 
```c
printf("Name:");
char Variable[2056];
scanf("%s",Variable);
printf("Hello ");
printf("%s", Variable);
printf("!");
printf("\nThat is a cool name though ");
printf("%s", Variable);
printf("\nHow Old Are You ");
printf("%s", Variable);
printf("?!:");
scanf("%s",Variable);
printf("\nWow ");
printf("%s", Variable);
printf("!");
```
You can see how it created the variable in the first input call, but used the existing one in the second.
