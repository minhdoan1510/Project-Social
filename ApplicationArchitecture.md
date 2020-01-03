## Cấu trúc chương trình

# Client

- Sử dụng ADO.Net để giao tiếp với database
- Xử lý và gửi tín hiệu cho server
- Nhận và xử lý tín hiệu từ server
- Phân task cho từng phân vùng chạy

# Server

- Xử lý và gửi tín hiệu cho Client
- Nhận và xử lý tín hiệu từ Client
- Xử lý các hành vi: SendMess, UserOnline, SendNotify, HandleLogin
- Phân chia thread chạy và xử lý nhiều user cùng truy cập trong một lúc

![Server](docs/Images/Server.PNG)

![HandleRequestLogin](docs/Images/HandleRequestLogin.PNG)

![handleMess](docs/Images/handleMess.PNG)

# Handle Client-Server

![Login](docs/Images/Login.png)

Xử lý đăng nhập trên client

![SendMess](docs/Images/SendMess.PNG)

Xử Lý Gửi tin nhắn giữa các client

# Database

![Diagrams](docs/Images/Diagrams.png)
