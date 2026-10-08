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

imgBGR = cv2.cvtColor(img, cv2.COLOR_RGB2BGR)

r = imgBGR[:, :, 2]
g = imgBGR[:, :, 1]
b = imgBGR[:, :, 0]

ra = imgBGR[:, :, [0,2]]
rv = imgBGR[:, :, [0,1]]
va = imgBGR[:, :, [1,2]]


red_img = np.zeros_like(imgBGR)
red_img[:, :, 2] = r

green_img = np.zeros_like(imgBGR)
green_img[:, :, 1] = g

blue_img = np.zeros_like(imgBGR)
blue_img[:, :, 0] = b



cyan_img = np.zeros_like(imgBGR)
cyan_img[:, :, [1,2]] = va


magenta_img = np.zeros_like(imgBGR)
magenta_img[:, :, [0,2]] = ra

yellow_img = np.zeros_like(imgBGR)
yellow_img[:, :, [0,1]] = rv

base, ext = os.path.splitext(img_path)
cv2.imwrite(base + "_red" + ext, red_img)
cv2.imwrite(base + "_green" + ext, green_img)
cv2.imwrite(base + "_blue" + ext, blue_img)

cv2.imwrite(base + "_cyan" + ext, cyan_img)
cv2.imwrite(base + "_magenta" + ext, magenta_img)
cv2.imwrite(base + "_yellow" + ext, yellow_img)

#print("Capas RGB guardadas correctamente. En" + base)
print("Imagen Procesada Correctamente")