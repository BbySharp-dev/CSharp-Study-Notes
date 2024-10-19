// * Arithmetic Operators
            int a = 10;
            int b = 3;
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"a + b = {a + b}");  // Cộng
            Console.WriteLine($"a - b = {a - b}");  // Trừ
            Console.WriteLine($"a * b = {a * b}");  // Nhân
            Console.WriteLine($"a / b = {a / b}");  // Chia (phần nguyên)
            Console.WriteLine($"a % b = {a % b}");  // Lấy phần dư

            // * Assignment Operators
            int c = 5;
            Console.WriteLine("\\nAssignment Operators:");
            c += 2;  // Tương đương c = c + 2
            Console.WriteLine($"c += 2: {c}");
            c *= 3;  // Tương đương c = c * 3
            Console.WriteLine($"c *= 3: {c}");

            // * Comparison Operators
            Console.WriteLine("\\nComparison Operators:");
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"a != b: {a != b}");
            Console.WriteLine($"a > b: {a > b}");
            Console.WriteLine($"a < b: {a < b}");

            // * Logical Operators
            bool x = true;
            bool y = false;
            Console.WriteLine("\\nLogical Operators:");
            Console.WriteLine($"x && y: {x && y}");  // AND
            Console.WriteLine($"x || y: {x || y}");  // OR
            Console.WriteLine($"!x: {!x}");          // NOT

            // * Unary Operators
            int d = 5;
            Console.WriteLine("\\nUnary Operators:");
            Console.WriteLine($"d++: {d++}");  // Post-increment: Hiện giá trị trước, tăng sau
            Console.WriteLine($"++d: {++d}");  // Pre-increment: Tăng giá trị trước, hiện sau
            Console.WriteLine($"d--: {d--}");  // Post-decrement: Hiện giá trị trước, giảm sau
            Console.WriteLine($"--d: {--d}");  // Pre-decrement: Giảm giá trị trước, hiện sau

            // * Ternary Operator
            int max = (a > b) ? a : b;
            Console.WriteLine("\\nTernary Operator:");
            Console.WriteLine($"Max of a and b is: {max}");

            // * Null-coalescing Operator
            string str = null;
            string result = str ?? "Default String";
            Console.WriteLine("\\nNull-coalescing Operator:");
            Console.WriteLine($"The result is: {result}");

            // * Null-conditional Operator
            string text = null;
            int? length = text?.Length;
            Console.WriteLine("\\nNull-conditional Operator:");
            Console.WriteLine($"Length of text (if not null): {length}");

            // * Bitwise Operators
            Console.WriteLine("\\nBitwise Operators:");
            int bitA = 5;  // 0101 in binary
            int bitB = 3;  // 0011 in binary
            Console.WriteLine($"bitA & bitB = {bitA & bitB}");  // AND
            Console.WriteLine($"bitA | bitB = {bitA | bitB}");  // OR
            Console.WriteLine($"bitA ^ bitB = {bitA ^ bitB}");  // XOR
            Console.WriteLine($"~bitA = {~bitA}");              // NOT
            Console.WriteLine($"bitA << 1 = {bitA << 1}");      // Left Shift
            Console.WriteLine($"bitA >> 1 = {bitA >> 1}");      // Right Shift