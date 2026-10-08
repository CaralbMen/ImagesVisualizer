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

# b, g, r = cv2.split(img)
cr = img[:, :, 0]
cg = img[:, :, 1]
cb = img[:, :, 2]

R = np.zeros_like(img)
R[:, :, 0] = cr
G = np.zeros_like(img)
G[:, :, 1] = cg
B = np.zeros_like(img)
B[:, :, 2] = cb

base, ext = os.path.splitext(img_path)
cv2.imwrite(base + "_red" + ext, R)
cv2.imwrite(base + "_green" + ext, G)
cv2.imwrite(base + "_blue" + ext, B)

#print("Capas RGB guardadas correctamente. En" + base)
print("Imagen Procesada Correctamente")