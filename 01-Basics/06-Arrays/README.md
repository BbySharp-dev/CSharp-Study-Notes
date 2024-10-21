# 🧠 C# Arrays - Study and Interview Guide

Welcome to the **C# Arrays Study and Interview Guide**! This repository covers **all array-related concepts** from **basic to advanced** and includes **interview questions** and **problem-solving exercises** to improve your understanding and thinking ability regarding arrays in C#.

---

## 📑 Mục lục:

1. [Kiến thức về Arrays trong C#](#kiến-thức-về-arrays-trong-c)
   - [Cơ bản](#cơ-bản)
   - [Trung bình](#trung-bình)
   - [Nâng cao](#nâng-cao)
2. [Bộ câu hỏi phỏng vấn từ dễ đến khó](#bộ-câu-hỏi-phỏng-vấn-từ-dễ-đến-khó)
3. [Câu hỏi giải quyết vấn đề để tăng tư duy](#câu-hỏi-giải-quyết-vấn-đề-để-tăng-tư-duy)
4. [Tài liệu tham khảo](#tài-liệu-tham-khảo)

---

## Kiến thức về Arrays trong C#

### 1. Cơ bản:

- **Array là gì?**

  - Mảng là một cấu trúc dữ liệu lưu trữ nhiều phần tử cùng loại, với kích thước cố định.
  - Cú pháp khai báo:
    ```csharp
    int[] numbers = new int[5]; // Mảng lưu trữ 5 phần tử kiểu int
    ```

- **Truy cập phần tử mảng:**

  - Phần tử trong mảng được truy cập bằng chỉ số (index) bắt đầu từ 0.
    ```csharp
    int firstElement = numbers[0]; // Phần tử đầu tiên
    ```

- **Khởi tạo mảng với các giá trị:**
  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  ```

### 2. Trung bình:

- **Mảng nhiều chiều (Multidimensional Array):**

  - Mảng nhiều chiều giúp lưu trữ các mảng trong mảng.
    ```csharp
    int[,] matrix = new int[3, 3]; // Mảng 2 chiều với 3 hàng và 3 cột
    ```

- **Mảng răng cưa (Jagged Array):**
  - Mảng răng cưa là mảng chứa các mảng con có kích thước khác nhau.
    ```csharp
    int[][] jaggedArray = new int[3][];
    jaggedArray[0] = new int[2];
    jaggedArray[1] = new int[3];
    jaggedArray[2] = new int[4];
    ```

### 3. Nâng cao:

- **Sử dụng LINQ với mảng:**

  - LINQ giúp lọc, sắp xếp và thực hiện các phép toán phức tạp trên mảng.
    ```csharp
    var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
    Console.WriteLine("Các số chẵn: " + string.Join(", ", evenNumbers));
    ```

- **Array.Copy() và Array.Clone():**

  - `Array.Copy()` cho phép sao chép một phần hoặc toàn bộ mảng.
  - `Array.Clone()` tạo một bản sao nông (shallow copy) của mảng.
    ```csharp
    int[] copiedArray = (int[]) numbers.Clone();
    ```

- **Xử lý ngoại lệ trong mảng:**
  - Lỗi thường gặp với mảng bao gồm `IndexOutOfRangeException` khi truy cập chỉ số không hợp lệ.
    ```csharp
    try {
        int[] array = null;
        Console.WriteLine(array.Length);  // NullReferenceException
    } catch (NullReferenceException ex) {
        Console.WriteLine("Mảng chưa được khởi tạo: " + ex.Message);
    }
    ```

---

## Bộ câu hỏi phỏng vấn từ dễ đến khó

### 🔰 Câu hỏi dễ:

1. **Mảng là gì trong C#? Khai báo mảng như thế nào?**
2. **Làm sao để truy cập phần tử của mảng?**
3. **Phân biệt `Array.Length` và `Array.Rank`?**
4. **Làm sao để lặp qua tất cả phần tử trong mảng?**
5. **Làm thế nào để khởi tạo mảng rỗng?**

### ⚙️ Câu hỏi trung bình:

1. **Mảng nhiều chiều là gì? Làm thế nào để khai báo và truy cập mảng nhiều chiều?**
2. **Sự khác nhau giữa mảng răng cưa (Jagged Array) và mảng nhiều chiều (Multidimensional Array)?**
3. **Làm sao để sao chép một mảng trong C#? Phân biệt giữa `Clone()` và `Copy()`?**
4. **Cách sắp xếp mảng tăng dần và giảm dần bằng `Array.Sort()`?**
5. **Làm thế nào để tìm kiếm một phần tử trong mảng?**

### 🚀 Câu hỏi nâng cao:

1. **Sử dụng LINQ để tìm các phần tử trong mảng thỏa mãn điều kiện nào đó?**
2. **Làm sao để xử lý lỗi khi truy cập chỉ số không hợp lệ trong mảng (IndexOutOfRangeException)?**
3. **Giải thích sự khác nhau giữa mảng tham chiếu và mảng kiểu giá trị trong bộ nhớ.**
4. **Làm thế nào để so sánh hai mảng có cùng giá trị phần tử hay không?**
5. **Mảng trong C# có phải là mảng động không? Làm thế nào để tạo một mảng động thực sự?**

---

## Câu hỏi giải quyết vấn đề để tăng tư duy

1. **Tìm số nhỏ nhất trong mảng:**

   - Hãy viết chương trình tìm số nhỏ nhất trong mảng số nguyên.
   - **Gợi ý:** Dùng vòng lặp `for` và so sánh các giá trị.

2. **Sắp xếp mảng số nguyên:**

   - Viết chương trình sắp xếp mảng số nguyên theo thứ tự tăng dần hoặc giảm dần mà không sử dụng `Array.Sort()`.
   - **Gợi ý:** Thực hiện thuật toán sắp xếp nổi bọt (Bubble Sort).

3. **Đếm số lần xuất hiện của phần tử trong mảng:**

   - Viết chương trình đếm số lần xuất hiện của mỗi phần tử trong mảng số nguyên.
   - **Gợi ý:** Sử dụng `Dictionary` để lưu trữ các phần tử và số lần xuất hiện.

4. **Tính tổng của mảng một chiều:**

   - Viết chương trình tính tổng tất cả các giá trị trong mảng.
   - **Gợi ý:** Dùng vòng lặp `for` để cộng dồn các giá trị.

5. **Chuyển đổi mảng 1 chiều thành mảng 2 chiều:**
   - Viết chương trình nhận vào một mảng 1 chiều và chuyển nó thành mảng 2 chiều.
   - **Gợi ý:** Xác định số hàng và cột của mảng 2 chiều dựa trên độ dài của mảng 1 chiều.

---

## Tài liệu tham khảo

1. [Microsoft Docs - Arrays in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
2. [LINQ in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
3. [Sorting Algorithms in C#](https://www.geeksforgeeks.org/sorting-algorithms/)

---

### 🏗️ Được soạn bởi [BbySharp-dev](https://github.com/BbySharp-dev)
