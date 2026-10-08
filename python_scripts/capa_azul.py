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
azulBajo = np.array([100, 100, 20], np.uint8)
azulAlto = np.array([125, 255, 255], np.uint8)

imgHSV = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)

maskAzul = cv2.inRange(imgHSV, azulBajo, azulAlto)

#poner en cero los pixeles que no se encuentren dentro del rango anterior
maskB = cv2.bitwise_and(img, img, mask= maskAzul)

if img is None:
    print(f"Error: OpenCV no pudo leer la imagen en:\n{img_path}")
    sys.exit(1)

base, ext = os.path.splitext(img_path)


if os.path.exists(base + "_blue" + ext):
    print("Imagen Procesada Correctamente")
else:
    cv2.imwrite(base + "_blue" + ext, maskB)
    print("Imagen Procesada Correctamente")
