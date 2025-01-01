
Newtonian Black Hole สามารถสร้างได้ไม่ยากโดยการใส่ความเร่งให้กับแสงที่อยู่ใกล้หลุมดำ (ในที่นี้คือ Ray ใน Ray-Marching Algo นั่นเอง) ให้ขนาดเป็นไปตาม Inverse Square Law วิธีนี้เป็นแค่การประมาณแต่ผลลัพธ์ถือว่าออกมาดีพอสมควร หากใครสนใจ Exact Solution แนะนำให้ลองดู Schwarzschild metric ซึ่งเป็นคำตอบของ Einstein Field Equation


## วิธีติดตั้ง

### โปรแกรมที่ต้องมี 
- **CMake**

### ขั้นตอนการสร้างสำหรับ Window

1. **Clone repository**:

   ```bash
   git clone https://github.com/Quackudy/Double-Pendulum-in-SFML.git
   cd Double-Pendulum-in-SFML
   ```

2. Clone build file โดยใช้ cmake
   ```bash
   mkdir build
   cd build
   cmake ..

3. Build
   
   -เปิดไฟล์ .sln ใน Visual Studio
   
   -เลือกโฟลเดอร์ที่มี src อยู่ข้างใน และคลิกขวา กด Set as Startup Project
   
   -สามารถรันโปรแกรมได้


### Acknowledgement
https://learnopengl.com/Introduction
https://youtu.be/8sVvxeKI9Pk?si=vgcUen2-U62v9WZi



https://github.com/user-attachments/assets/8912b439-3b14-4666-8f50-1f677275cf39




