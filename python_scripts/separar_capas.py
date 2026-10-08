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

#imgBGR = cv2.cvtColor(img, cv2.COLOR_RGB2BGR)
imgBGR = img  # La imagen ya está en formato BGR al leerla con cv2.imread
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

if not os.path.exists(base + "_sred" + ext):
    cv2.imwrite(base + "_sred" + ext, red_img)

if not os.path.exists(base + "_sgreen" + ext):
    cv2.imwrite(base + "_sgreen" + ext, green_img)

if not os.path.exists(base + "_sblue" + ext):
    cv2.imwrite(base + "_sblue" + ext, blue_img)

if not os.path.exists(base + "_scyan" + ext):
    cv2.imwrite(base + "_scyan" + ext, cyan_img)

if not os.path.exists(base + "_smagenta" + ext):
    cv2.imwrite(base + "_smagenta" + ext, magenta_img)

if not os.path.exists(base + "_syellow" + ext):
    cv2.imwrite(base + "_syellow" + ext, yellow_img)

#print("Capas RGB guardadas correctamente. En" + base)
print("Imagen Procesada Correctamente")