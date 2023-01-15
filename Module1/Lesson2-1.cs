// Integer types

/*
Byte
The byte data type stores numbers from 0 to 255. It occupies 8-bit in the memory. The byte keyword is an alias of the Byte struct in .NET.
The sbyte is the same as byte, but it can store negative numbers from -128 to 127. The sbyte keyword is an alias for SByte struct in .NET.
*/
byte b1 = 255;
byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
sbyte sb1 = -128; 
sbyte sb2 = 127; 

Console.WriteLine(Byte.MaxValue);//255
Console.WriteLine(Byte.MinValue);//0
Console.WriteLine(SByte.MaxValue);//127
Console.WriteLine(SByte.MinValue);//-128

/*
Short
The short data type is a signed integer that can store numbers from -32,768 to 32,767. It occupies 16-bit memory. The short keyword is an alias for Int16 struct in .NET.
The ushort data type is an unsigned integer. It can store only positive numbers from 0 to 65,535. The ushort keyword is an alias for UInt16 struct in .NET.
*/
short s1 = -32768;
short s2 = 32767;
short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

ushort us1 = 65535;
ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

Console.WriteLine(Int16.MaxValue);//32767
Console.WriteLine(Int16.MinValue);//-32768
Console.WriteLine(UInt16.MaxValue);//65535
Console.WriteLine(UInt16.MinValue);//0

/*
Int
The int data type is 32-bit signed integer. It can store numbers from -2,147,483,648 to 2,147,483,647. The int keyword is an alias of Int32 struct in .NET.
The uint is 32-bit unsigned integer. The uint keyword is an alias of UInt32 struct in .NET. It can store positive numbers from 0 to 4,294,967,295. 
Optionally use U or u suffix after a number to assign it to uint variable.
*/
int i = -2147483648;
int j = 2147483647;
int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

uint ui1 = 4294967295;
uint ui2 =-1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

Console.WriteLine(Int32.MaxValue);//2147483647
Console.WriteLine(Int32.MinValue);//-2147483648
Console.WriteLine(UInt32.MaxValue);//4294967295
Console.WriteLine(UInt32.MinValue);//0

/*
Long
The long type is 64-bit signed integers. It can store numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807. 
Use l or L suffix with number to assign it to long type variable. The long keyword is an alias of Int64 struct in .NET.
The ulong type stores positive numbers from 0 to 18,446,744,073,709,551,615. If a number is suffixed by UL, Ul, uL, ul, LU, Lu, lU, or lu, its type is ulong. 
The ulong keyword is an alias of UInt64 struct in .NET.
*/
long l1 = -9223372036854775808;
long l2 = 9223372036854775807;

ulong ul1 = 18223372036854775808ul;
ulong ul2 = 18223372036854775808UL;

Console.WriteLine(Int64.MaxValue);//9223372036854775807
Console.WriteLine(Int64.MinValue);//-9223372036854775808
Console.WriteLine(UInt64.MaxValue);//18446744073709551615
Console.WriteLine(UInt64.MinValue);//0

/*-----------------------------------------------Floating Point Types--------------------------------------
Floating-point numbers are positive or negative numbers with one or more decimal points. C# includes three data types for floating-point numbers: float, double, and decimal. */

/*
Float
The float data type can store fractional numbers from 3.4e−038 to 3.4e+038. It occupies 4 bytes in the memory. The float keyword is an alias of Single struct in .NET.
Use f or F suffix with literal to make it float type */
float f1 = 123456.5F;
float f2 = 1.123456f;

Console.WriteLine(f1);//123456.5
Console.WriteLine(f2);//1.123456

/*
Double
The double data type can store fractional numbers from 1.7e−308 to 1.7e+308. It occupies 8 bytes in the memory. The double keyword is an alias of the Double struct in .NET.
Use d or D suffix with literal to make it double type */
double d1 = 12345678912345.5d;
double d2 = 1.123456789123456d;

Console.WriteLine(d1);//12345678912345.5
Console.WriteLine(d2);//1.123456789123456

/*
Decimal
The decimal data type can store fractional numbers from ±1.0 x 10-28 to ±7.9228 x 1028. It occupies 16 bytes in the memory. The decimal is a keyword alias of the Decimal struct in .NET.
The decimal type has more precision and a smaller range than both float and double, and so it is appropriate for financial and monetary calculations.
Use m or M suffix with literal to make it decimal type. */
decimal d1 = 123456789123456789123456789.5m;
decimal d2 = 1.1234567891345679123456789123m;

Console.WriteLine(d1);
Console.WriteLine(d2);
