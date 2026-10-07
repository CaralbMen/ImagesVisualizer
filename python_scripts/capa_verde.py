import cv2
import sys
import os
import numpy as np

if len(sys.argv) < 2:
    print("Error: No se proporcionó la ruta de la imagen.")
    sys.exit(1)

img_path = sys.argv[1]

if not os.path.exists(img_path):
    print(f"Error: El archivo no existe en la ruta:\n{img_path}")
    sys.exit(1)

img = cv2.imread(img_path)
#img = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)

#Segmentar color azul
verdeBajo = np.array([35, 40, 40], np.uint8)
verdeAlto = np.array([85, 255, 255], np.uint8)

imgHSV = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)

maskVerde = cv2.inRange(imgHSV, verdeBajo, verdeAlto)

#poner en cero los pixeles que no se encuentren dentro del rango anterior
maskV = cv2.bitwise_and(img, img, mask= maskVerde)

if img is None:
    print(f"Error: OpenCV no pudo leer la imagen en:\n{img_path}")
    sys.exit(1)

base, ext = os.path.splitext(img_path)
cv2.imwrite(base + "_green" + ext, maskV)

print("Capa verde guardada correctamente. En" + base)