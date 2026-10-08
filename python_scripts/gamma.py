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


def gamma_correction(imagen, gamma):
    imgNorm = imagen / 255.0
    imgGamma = np.power(imgNorm, gamma)
    return np.uint8(imgGamma * 255)

#Grid
imagenGray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

gamma = int(sys.argv[2])
#Gris Gamma
imgGgamma = gamma_correction(imagenGray, gamma)

imgRGB = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)
imgRGBGamma = gamma_correction(imgRGB, gamma)

base, ext = os.path.splitext(img_path)

cv2.imwrite(base + "_gamma"+ str(gamma) + ext, imgRGBGamma)

print("Imagen gamma guardada correctamente. En" + base)



