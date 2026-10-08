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

if img is None:
    print(f"Error: OpenCV no pudo leer la imagen en:\n{img_path}")
    sys.exit(1)

#Segmentar color rojo
#Se modifican los rangos para que detecte bien todo el rojo
rojoBajo1 = np.array([0, 60, 20], np.uint8)
rojoAlto1 = np.array([10, 255, 255], np.uint8)
rojoBajo2 = np.array([168, 60, 20], np.uint8)
rojoAlto2 = np.array([180, 255, 255], np.uint8)

imgHSV = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)

maskRed1 = cv2.inRange(imgHSV, rojoBajo1, rojoAlto1)
maskRed2 = cv2.inRange(imgHSV, rojoBajo2, rojoAlto2)
maskRoja = cv2.add(maskRed1, maskRed2)

#poner en cero los pixeles que no se encuentren dentro del rango anterior
maskB = cv2.bitwise_and(img, img, mask= maskRoja)

base, ext = os.path.splitext(img_path)

if os.path.exists(base + "_red" + ext):
    print("Imagen Procesada Correctamente")
else:
    cv2.imwrite(base + "_red" + ext, maskB)
    print("Imagen Procesada Correctamente")