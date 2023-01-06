# Thank you for your interest in making this tool better!
Below are some guidelines to make it easier for you.

## Code Style
Try to replicate the code style used in the file(s) you are contributing to.

### Indentation
Tabs are used for all cs files.

### Blocks
I'm not picky about where the opening bracket lives, it can either be on the same line or on the line below, but please ensure there is a space before the opening and closing brackets. Spacing rules apply for terinary operators as well.  


I am also ok with the statement being on the line below tabbed (without braces) for single statement blocks if you see fit. Spaces should also be between variable and operators (unless declaring a default value for a method argument, spaces should not be included here) but not before/after a closing parenthesis. There should also not be spaces between a method call and their argument parenthesis.


Good:
```csharp
if (a == 0) {
    DoSomething(a);
}

if (b == 0) 
{
    DoSomething(b);
}

if (c == 0) DoSomething(c);

if (d == 0)
    DoSomething(d)

// Default Value Example
public void DoSomething(int a, bool doIt=false) {

}

//Also OK
public void DoAnother(int b, bool doIt=false) 
{

}
```

Not Good:
```csharp
if (a==0){
    DoSomething(a);
}

if ( a== 1 ){
    DoSomething ( a);
}
```

### Statement Spacing
Spaces between operators and their variable/value are up to your discretion, but it is preferred to have a space between. There very well are existing instances of no spacing, so it is ok if you prefer to not include a space.
```csharp
// Like this
myVar += 1;

// Rather than, but again up to your discretion.
myVar +=1;
```

### Comments
Comments should have a space between the comment characters and the text of the comment. Multi-line/Block comments should have each 'inner line' preceded with an asterisk, but this is not enforced. Multi Line comments are also ok with // delimeters.

```csharp
// Like this
/*
 * Spacing goes
 * after each 
 * comment character
*/

// This is
// also OK

//Not like this
/*
*don't leave
*out the
*spaces.
*/
```

When in doubt, do your best to fit the style of the file you are working on.