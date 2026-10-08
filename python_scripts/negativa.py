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


#extraer lo canales
cRojo = img[:, :, 0]
cVerde = img[:, :, 1]
cAzul = img[:, :, 2]

#convertir a grises
grayImage= 0.2989 * cRojo + 0.5870 * cVerde + 0.1140 * cAzul
grayImage = grayImage.astype(np.uint8)

negativeImage = 255 - grayImage

base, ext = os.path.splitext(img_path)

if os.path.exists(base + "_negativa" + ext):
    print("Imagen Procesada Correctamente")
else:
    cv2.imwrite(base + "_negativa" + ext, negativeImage)
    print("Imagen Procesada Correctamente")


