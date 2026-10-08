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




imgHSV = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)


base, ext = os.path.splitext(img_path)
cv2.imwrite(base + "_hsv" + ext, imgHSV)

#print("Imagen HSV guardada correctamente. En" + base)
print("Imagen Procesada Correctamente")



