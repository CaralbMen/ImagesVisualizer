import cv2
import sys
import os

# Carpeta de salida
output_dir = "processed_images"
os.makedirs(output_dir, exist_ok=True)

# Encender cámara
cap = cv2.VideoCapture(0)  # 0 = cámara por defecto
ret, frame = cap.read()

if ret:
    output_path = os.path.join(output_dir, "captured.jpg")
    cv2.imwrite(output_path, frame)
    print(output_path)  # Imprime la ruta para que C# la lea
else:
    print("Error al capturar imagen")

cap.release()
