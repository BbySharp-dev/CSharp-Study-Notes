# 📘 Value Types trong C# – Tài liệu ôn tập phỏng vấn

## 1️⃣ Tổng quan về Value Types

**Value Types** là những kiểu dữ liệu lưu trữ giá trị trực tiếp trên **stack**. Khi bạn tạo một biến **value type**, giá trị thực của biến sẽ được lưu trữ trực tiếp. Một số **Value Types** phổ biến trong C# bao gồm: `int`, `double`, `char`, `bool`, `struct`, `enum`. Các **value types** có tốc độ truy cập nhanh và phù hợp với dữ liệu nhỏ.

- **Nullable types**: C# hỗ trợ **nullable types** để cho phép các **value types** có thể chứa giá trị `null`. Điều này giúp xử lý các giá trị chưa xác định trong các biến kiểu giá trị.

---

## 2️⃣ Câu hỏi phỏng vấn về Value Types

### Câu hỏi 1: Value Type là gì trong C#?

**Khái niệm**:  
**Value Type** là kiểu dữ liệu lưu trữ trực tiếp giá trị trong bộ nhớ **stack**. Khi được tạo, biến kiểu này sẽ chứa giá trị thực chứ không phải tham chiếu tới địa chỉ bộ nhớ như với **reference types**.

---

### Câu hỏi 2: Sự khác nhau giữa Value Type và Reference Type là gì?

**Khái niệm**:

- **Value Type** lưu trữ giá trị trực tiếp, trong khi **Reference Type** lưu trữ tham chiếu đến địa chỉ của giá trị trong **heap**.
- **Value Types** có mặt trên **stack**, còn **Reference Types** được lưu trên **heap**, và có thể trỏ đến giá trị hoặc `null`.

---

### Câu hỏi 3: Các kiểu dữ liệu nào là Value Types trong C#?

**Khái niệm**:  
Một số **Value Types** phổ biến trong C# là:

- **int**: Số nguyên
- **double**: Số thực
- **char**: Ký tự Unicode
- **bool**: Giá trị logic (`true` hoặc `false`)
- **enum**: Tập hợp các hằng số
- **struct**: Cấu trúc dữ liệu chứa nhiều thành phần khác nhau

---

### Câu hỏi 4: Boxing và Unboxing là gì?

**Khái niệm**:

- **Boxing** là quá trình chuyển một **value type** thành **reference type** bằng cách đóng gói giá trị trong một đối tượng `object`.
- **Unboxing** là quá trình chuyển đổi ngược lại từ **reference type** sang **value type**.

---

### Câu hỏi 5: Nullable Types là gì? Sử dụng ra sao?

**Khái niệm**:  
**Nullable Types** cho phép một **value type** chứa giá trị `null`. Cú pháp thêm dấu `?` vào sau kiểu dữ liệu để khai báo, ví dụ: `int?`, `double?`.

---

### Câu hỏi 6: Sự khác biệt giữa `const` và `readonly` trong C#?

**Khái niệm**:

- **const**: Giá trị phải được xác định tại thời điểm biên dịch và không thể thay đổi sau đó.
- **readonly**: Có thể khởi tạo trong constructor và không thể thay đổi sau đó, tuy nhiên có thể được gán giá trị tại runtime.

---

### Câu hỏi 7: Enum là gì và khi nào sử dụng?

**Khái niệm**:  
**Enum** là một kiểu dữ liệu có tập hợp các hằng số, giúp mã dễ đọc hơn và giảm thiểu việc sử dụng các số "magic numbers". **Enum** thường được sử dụng khi cần định nghĩa một tập hợp giá trị cố định.

---

### Câu hỏi 8: Struct là gì? Khác gì so với class?

**Khái niệm**:  
**Struct** là một kiểu dữ liệu giá trị dùng để nhóm các thuộc tính có liên quan. **Struct** khác với **class** ở chỗ nó không hỗ trợ kế thừa, và các **struct** thường được dùng khi cần tạo ra các đối tượng nhẹ, không thay đổi nhiều.

---

### Câu hỏi 9: Type Inference là gì? Vai trò của `var` là gì?

**Khái niệm**:  
**Type inference** là cơ chế của trình biên dịch tự động suy luận kiểu dữ liệu dựa trên giá trị được gán. Từ khóa `var` giúp mã ngắn gọn hơn mà không làm mất đi sự rõ ràng, vì trình biên dịch vẫn xác định chính xác kiểu dữ liệu.

---

### Câu hỏi 10: Khi nào nên sử dụng Boxing và Unboxing?

**Khái niệm**:  
**Boxing** và **Unboxing** được sử dụng khi cần chuyển đổi giữa **value type** và **reference type**, nhưng nên hạn chế sử dụng trong các ứng dụng yêu cầu hiệu suất cao do chi phí tài nguyên.

---

## 3️⃣ Các lưu ý quan trọng

- **Value Types** lưu trữ giá trị trực tiếp, ngược với **Reference Types** lưu trữ tham chiếu.
- **Nullable Types** cung cấp khả năng xử lý giá trị `null` cho **Value Types**.
- **Boxing** và **Unboxing** có thể ảnh hưởng đến hiệu năng nếu sử dụng không đúng cách.
- **Struct** thường được dùng cho các giá trị nhẹ, ít thay đổi và không yêu cầu tính năng như kế thừa.

---

> Được soạn bởi [BbySharp-dev](https://github.com/BbySharp-dev)
