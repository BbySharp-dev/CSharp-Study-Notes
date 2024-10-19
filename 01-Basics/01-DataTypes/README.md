# 📘 C# Interview Preparation – Value Types (Dễ, Trung Bình, Nâng Cao & Câu Hỏi Giải Quyết Vấn Đề)

## 1️⃣ Tổng quan về Value Types

**Value Types** là kiểu dữ liệu trong C# mà giá trị của nó được lưu trữ trực tiếp trên **stack**. Các kiểu dữ liệu này bao gồm: `int`, `double`, `bool`, `char`, `struct`, và `enum`. Đặc điểm chính của value types là chúng lưu trữ giá trị trực tiếp chứ không phải lưu trữ tham chiếu đến bộ nhớ như **reference types**.

---

## 2️⃣ Câu hỏi phỏng vấn cơ bản về Value Types

### Câu hỏi 1: Value Type là gì trong C#?

**Mục tiêu**: Hiểu khái niệm cơ bản về value type.

- **Gợi ý trả lời**: Value Type là kiểu lưu trữ giá trị trực tiếp trong biến và trên stack, không tham chiếu đến địa chỉ bộ nhớ khác.

---

### Câu hỏi 2: Các kiểu dữ liệu nào là Value Types trong C#?

**Mục tiêu**: Kiểm tra kiến thức về các kiểu dữ liệu.

- **Gợi ý trả lời**: Bao gồm `int`, `double`, `char`, `bool`, `struct`, `enum`.

---

### Câu hỏi 3: Sự khác biệt giữa Value Type và Reference Type là gì?

**Mục tiêu**: Đánh giá sự hiểu biết về sự khác nhau giữa hai kiểu dữ liệu.

- **Gợi ý trả lời**: Value Types lưu trữ giá trị trực tiếp, trong khi Reference Types lưu trữ tham chiếu đến địa chỉ bộ nhớ trong heap.

---

## 3️⃣ Câu hỏi phỏng vấn trung bình về Value Types

### Câu hỏi 4: Boxing và Unboxing là gì? Tại sao cần chú ý đến hiệu năng?

**Mục tiêu**: Hiểu về boxing và unboxing và tác động của nó đến hiệu năng.

- **Gợi ý trả lời**: Boxing là quá trình chuyển value type thành reference type, unboxing là chuyển ngược lại. Cả hai đều có chi phí hiệu năng.

---

### Câu hỏi 5: Enum là gì và tại sao nên sử dụng nó?

**Mục tiêu**: Kiểm tra khả năng sử dụng enum.

- **Gợi ý trả lời**: Enum là tập hợp các hằng số, giúp mã dễ đọc và bảo trì hơn.

---

### Câu hỏi 6: Sự khác nhau giữa `const` và `readonly`?

**Mục tiêu**: Hiểu về cách sử dụng `const` và `readonly`.

- **Gợi ý trả lời**: `const` chỉ định giá trị hằng tại thời điểm biên dịch, `readonly` chỉ có thể gán trong constructor hoặc tại thời điểm khởi tạo.

---

## 4️⃣ Câu hỏi phỏng vấn nâng cao về Value Types

### Câu hỏi 7: Tác động của Boxing và Unboxing đến bộ nhớ và hiệu năng?

**Mục tiêu**: Đánh giá kiến thức về hiệu suất.

- **Gợi ý trả lời**: Boxing/Unboxing yêu cầu thêm thao tác chuyển đổi và lưu trữ trên heap, dẫn đến tiêu tốn bộ nhớ và giảm hiệu năng.

---

### Câu hỏi 8: Khi nào nên sử dụng Struct thay vì Class?

**Mục tiêu**: Kiểm tra khả năng phân biệt khi nào sử dụng struct hoặc class.

- **Gợi ý trả lời**: Sử dụng struct khi cần lưu trữ các giá trị nhỏ, không thay đổi nhiều. Sử dụng class khi cần tính năng mạnh hơn như kế thừa hoặc đa hình.

---

### Câu hỏi 9: Tại sao phải sử dụng nullable types?

**Mục tiêu**: Đánh giá khả năng hiểu và sử dụng nullable types.

- **Gợi ý trả lời**: Nullable types cho phép các value types như `int`, `double` có thể nhận giá trị `null`, giúp xử lý các trường hợp dữ liệu không xác định.

---

## 5️⃣ Câu hỏi giải quyết vấn đề

### Câu hỏi 10: Bạn sẽ giải quyết như thế nào khi gặp vấn đề về hiệu năng do sử dụng quá nhiều Boxing/Unboxing?

**Mục tiêu**: Kiểm tra khả năng giải quyết vấn đề về hiệu năng trong C#.

- **Gợi ý trả lời**: Giảm thiểu boxing/unboxing bằng cách sử dụng Generics, giúp tránh việc chuyển đổi giữa value types và reference types.

---

### Câu hỏi 11: Bạn sẽ xử lý như thế nào nếu cần lưu trữ giá trị `null` cho một tập hợp số nguyên?

**Mục tiêu**: Kiểm tra khả năng sử dụng nullable types.

- **Gợi ý trả lời**: Sử dụng `int?` hoặc `nullable<int>` để lưu trữ các giá trị có thể `null`.

---

### Câu hỏi 12: Nếu cần lưu trữ tập hợp các giá trị số và chuỗi trong C#, bạn sẽ chọn struct hay class? Tại sao?

**Mục tiêu**: Kiểm tra khả năng lựa chọn struct hoặc class dựa trên yêu cầu.

- **Gợi ý trả lời**: Sử dụng struct nếu dữ liệu nhỏ và ít thay đổi, sử dụng class nếu dữ liệu phức tạp và có nhiều thay đổi.

---

### Câu hỏi 13: Trong một ứng dụng lớn, khi nào bạn cần sử dụng Boxing và Unboxing?

**Mục tiêu**: Đánh giá khả năng sử dụng Boxing và Unboxing đúng hoàn cảnh.

- **Gợi ý trả lời**: Sử dụng khi cần tương tác với các thư viện hoặc framework yêu cầu dữ liệu dạng object, nhưng nên hạn chế để tối ưu hiệu năng.

---

> Được soạn bởi [BbySharp-dev](https://github.com/BbySharp-dev)
