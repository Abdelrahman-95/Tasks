# Seaarch Task 

(Standard numeric format)

int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");


in one (1) pdf page:
1. why the output of this Equation = $30.00?
2. what is its benefit?
3. try another example with a different specifier with a screenshot of the output.


حرف الـ C ده اختصار لـ Currency، ومهمته إنه يغير "ستايل" الرقم من مجرد رقم عادي لشكل "فلوس"، فيضيف من نفسه علامة الـ $ ويضبط الكسور العشرية (.00).

بدل ما تتعب نفسك وتكتب علامة العملة وتنسق الأصفار يدوياً، الـ #C بيعملك ده بلمسة واحدة عشان الكود يبان احترافي ومنظم

:C (Currency): للفلوس (يضع $ وكسور).

:N (Number): للأرقام الكبيرة (يضع فواصل الآلاف ليجعل القراءة سهلة) 

int bigNumber = 1000000;
Console.WriteLine($"bigNumber : {bigNumber:N0}");

