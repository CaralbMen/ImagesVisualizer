# Reporte técnico: ImagesVisualizer

## 1. Datos generales

**Nombre del proyecto:** ImagesVisualizer  
**Tipo de aplicación:** Aplicación de escritorio Windows Forms  
**Objetivo:** Cargar o capturar imágenes, aplicar operaciones básicas de procesamiento digital y almacenar la información de usuarios e imágenes en MySQL.  
**Tecnologías principales:** C#, .NET Framework 4.8, Windows Forms, Python, OpenCV, NumPy, MySQL y AForge.NET.

> **Nota:** Completar los campos de institución, materia, integrantes, docente y fecha según el formato solicitado.

## 2. Introducción

El proyecto desarrolla un sistema de visión artificial capaz de recibir una imagen desde un archivo o una cámara web. Después de cargarla, el usuario puede visualizarla, guardarla en el equipo, almacenar una representación matricial de sus píxeles en una base de datos y aplicar transformaciones de procesamiento digital.

Las transformaciones implementadas son:

- Separación de la imagen en capas de color.
- Conversión a escala de grises.
- Conversión al espacio de color HSV.
- Segmentación y resaltado de colores rojo, verde y azul.

La interfaz principal se construyó con Windows Forms. Las operaciones de procesamiento se ejecutan desde scripts de Python y la comunicación con MySQL se realiza mediante consultas parametrizadas.

## 3. Objetivos

### 3.1 Objetivo general

Desarrollar una aplicación que permita visualizar y procesar imágenes digitales mediante operaciones de color, además de relacionar las imágenes almacenadas con los usuarios registrados.

### 3.2 Objetivos específicos

1. Registrar usuarios en una base de datos MySQL.
2. Proteger las contraseñas mediante un hash BCrypt.
3. Permitir el inicio de sesión mediante usuario y contraseña.
4. Cargar imágenes JPG, JPEG o PNG desde el equipo.
5. Capturar imágenes mediante la cámara web.
6. Guardar imágenes en `Resources/images`.
7. Convertir la imagen a una matriz RGB y almacenarla como JSON.
8. Ejecutar algoritmos de procesamiento con Python y OpenCV.
9. Mostrar el resultado del procesamiento en la interfaz.

## 4. Arquitectura general

El sistema está dividido en tres partes:

### 4.1 Aplicación de escritorio

La carpeta `application` contiene las ventanas y la lógica de la aplicación:

- `Form1.cs`: ventana de inicio de sesión.
- `Register.cs`: registro de usuarios.
- `Menu.cs`: carga, captura, guardado y envío de imágenes a procesamiento.
- `Procesamiento.cs`: ejecución de los filtros y visualización de resultados.
- `Connection.cs`: creación de la conexión a MySQL.

### 4.2 Scripts de procesamiento

La carpeta `python_scripts` contiene los algoritmos de procesamiento:

- `separar_capas.py`
- `grises.py`
- `hsv.py`
- `capa_roja.py`
- `capa_verde.py`
- `capa_azul.py`

Cada script recibe como argumento la ruta de una imagen y genera un nuevo archivo con el sufijo correspondiente.

### 4.3 Base de datos

La estructura se define en `BD.sql`. Se crean dos tablas:

- `usuarios`: información personal, nombre de usuario, correo y contraseña cifrada.
- `imagenes`: identificador del usuario y matriz de píxeles serializada en formato JSON.

La relación entre ambas tablas se establece mediante la llave foránea `imagenes.id_usuario -> usuarios.id`.

## 5. Requisitos de instalación

Para ejecutar el proyecto se requiere:

1. Windows.
2. Visual Studio con soporte para proyectos .NET Framework y Windows Forms.
3. .NET Framework 4.8.
4. MySQL Server ejecutándose en el puerto `3306`.
5. Python instalado y disponible como comando `python`.
6. Bibliotecas de Python:

```powershell
pip install opencv-python numpy
```

7. Paquetes de NuGet incluidos en el proyecto, entre ellos:

- MySql.Data
- BCrypt.Net-Next
- Newtonsoft.Json
- AForge
- AForge.Video
- AForge.Video.DirectShow
- DotNetEnv

## 6. Configuración de la base de datos

### Paso 1. Iniciar MySQL

Iniciar el servicio de MySQL y comprobar que esté disponible en:

```text
Host: 127.0.0.1
Puerto: 3306
Usuario: root
Base de datos: imagesVisualizer
```

### Paso 2. Ejecutar el script SQL

Abrir MySQL Workbench, phpMyAdmin o la consola de MySQL y ejecutar el contenido de `BD.sql`.

El script:

1. Crea la base `imagesVisualizer`.
2. Selecciona la base de datos.
3. Crea la tabla `usuarios`.
4. Crea la tabla `imagenes`.
5. Establece la relación entre usuario e imagen.

### Paso 3. Revisar las variables de entorno

El archivo `.env` contiene los parámetros de conexión:

```text
DB_HOST=127.0.0.1
DB_NAME=imagesVisualizer
DB_USER=root
DB_PASSWORD=
DB_PORT=3306
```

No se deben publicar contraseñas reales en el repositorio. Si MySQL utiliza una contraseña, colocarla únicamente en el entorno local.

## 7. Procedimiento de ejecución y prueba

### Paso 1. Abrir el proyecto

Abrir la solución `application\application.slnx` en Visual Studio y restaurar los paquetes si Visual Studio lo solicita.

### Paso 2. Compilar

Seleccionar la configuración **Debug** y compilar la solución. El proyecto está configurado para .NET Framework 4.8.

### Paso 3. Ejecutar la aplicación

Ejecutar el proyecto. La primera ventana mostrada es la pantalla de inicio de sesión.

### Paso 4. Registrar un usuario

1. Seleccionar el enlace para registrarse.
2. Capturar nombre, apellido paterno, apellido materno, usuario y correo.
3. Escribir la contraseña y confirmarla.
4. Presionar el botón de registro.
5. Verificar que aparezca el mensaje **Usuario registrado exitosamente**.

Durante este proceso la contraseña no se guarda en texto plano. `Register.cs` utiliza BCrypt para generar el hash antes de ejecutar el `INSERT` en la tabla `usuarios`.

### Paso 5. Iniciar sesión

1. Escribir el nombre de usuario registrado.
2. Escribir la contraseña.
3. Presionar **Entrar**.
4. El sistema consulta el usuario mediante un parámetro `@username`.
5. BCrypt compara la contraseña escrita con el hash almacenado.
6. Si la validación es correcta, se abre el menú principal.

### Paso 6. Cargar una imagen desde el equipo

1. Presionar **Buscar Foto**.
2. Seleccionar un archivo `.jpg`, `.jpeg` o `.png`.
3. La aplicación copia la imagen a `Resources/images`.
4. El nombre se genera con la fecha y hora para evitar colisiones.
5. La imagen se muestra en el control `PictureBox`.

### Paso 7. Capturar una imagen con la cámara

1. Presionar **Encender Cámara**.
2. El sistema busca los dispositivos de captura disponibles.
3. Se utiliza el primer dispositivo detectado.
4. La vista previa se muestra en el `PictureBox`.
5. Presionar **Tomar Foto**.
6. La captura se guarda como JPG en `Resources/images`.
7. La cámara se detiene después de guardar la imagen.

Si no existe una cámara, el sistema muestra el mensaje **No se encontró ninguna cámara**.

### Paso 8. Guardar la imagen en MySQL

1. Asegurarse de que exista una imagen cargada o capturada.
2. Si la cámara está activa, primero tomar la fotografía.
3. Presionar **Guardar**.
4. La aplicación recorre los píxeles de la imagen.
5. Cada píxel se convierte en los valores `R`, `G` y `B`.
6. La matriz tridimensional se serializa con Newtonsoft.Json.
7. El JSON se guarda en la columna `imagenes.imagen`.
8. La fila queda asociada al usuario mediante `id_usuario`.

### Paso 9. Abrir el módulo de procesamiento

Presionar **Procesar Imagen**. La aplicación abre la ventana `Procesamiento` y conserva la ruta de la imagen seleccionada.

### Paso 10. Separar la imagen en capas

Presionar **Separar en Capas**. La aplicación ejecuta:

```text
python_scripts/separar_capas.py
```

El script genera tres archivos:

```text
<nombre>_red.<extensión>
<nombre>_green.<extensión>
<nombre>_blue.<extensión>
```

Después, la interfaz oculta la imagen original y muestra las tres imágenes resultantes en controles separados.

### Paso 11. Convertir a escala de grises

Presionar **Gris**. El script `grises.py` calcula una combinación ponderada de los canales:

```text
Gray = 0.2989 R + 0.5870 G + 0.1140 B
```

El resultado se guarda con el sufijo `_gray`.

### Paso 12. Convertir a HSV

Presionar **HSV**. El script `hsv.py` transforma la imagen de BGR a HSV mediante `cv2.cvtColor` y guarda el resultado con el sufijo `_hsv`.

### Paso 13. Resaltar colores

Los botones de resaltado aplican segmentación por rangos HSV:

- **Destacar color rojo:** utiliza dos rangos porque el rojo se encuentra en los extremos del eje Hue.
- **Destacar color verde:** utiliza un rango HSV aproximado de `35` a `85`.
- **Destacar color azul:** utiliza un rango HSV aproximado de `100` a `125`.

Los píxeles fuera del rango se eliminan mediante una máscara y el resultado se guarda con `_red`, `_green` o `_blue`.

## 8. Descripción de los algoritmos

### 8.1 Lectura de imágenes

Los scripts validan que:

1. Se haya recibido una ruta.
2. El archivo exista.
3. OpenCV pueda leer correctamente la imagen.

Si alguna condición falla, el script escribe un mensaje de error y termina.

### 8.2 Separación de canales

OpenCV carga las imágenes en orden BGR. El script crea matrices vacías con el mismo tamaño de la imagen y coloca un canal en cada matriz para generar las imágenes de salida.

### 8.3 Conversión a gris

La conversión pondera cada componente de color según la percepción humana. El resultado se convierte a `uint8` para poder guardarse como imagen.

### 8.4 Segmentación HSV

La imagen se convierte a HSV y `cv2.inRange` construye una máscara binaria. `cv2.bitwise_and` conserva los píxeles que se encuentran dentro del rango seleccionado.

## 9. Resultados y evidencias

Las pruebas entregadas muestran los siguientes resultados:

1. **Imagen original de una herramienta:** se conserva la fotografía original y se genera una capa verde segmentada.
2. **Fotografía de tres personas:** se obtiene la imagen original, una versión en escala de grises, una máscara verde, una máscara roja y una representación HSV.
3. **Imagen del astronauta:** se obtiene la imagen original, una versión en escala de grises y una representación HSV.
4. **Separación de capas:** se generan archivos independientes para los canales de color.
5. **Interfaz gráfica:** se utilizan fondos personalizados para la pantalla de inicio de sesión y el menú principal.

Las evidencias se encuentran en `application/Resources/images` con nombres que incluyen la fecha y el sufijo del procesamiento, por ejemplo:

```text
20261007141127.jpg
20261007141127_gray.jpg
20261007141127_green.jpg
20261007141127_red.jpg
20261007141127_hsv.jpg
```

## 10. Manejo de errores observado

La aplicación muestra mensajes cuando:

- Faltan campos del registro.
- Las contraseñas no coinciden.
- El correo no tiene una estructura básica válida.
- El usuario no existe.
- La contraseña es incorrecta.
- No se puede conectar a MySQL.
- No existe una imagen para procesar.
- No se detecta una cámara.
- Un script Python no puede leer la imagen.

## 11. Limitaciones y trabajo futuro

Durante la revisión del código se identificaron estas consideraciones:

1. Los botones **Negativa**, **Gamma** y **Guardar** del formulario de procesamiento aparecen en la interfaz, pero no tienen una operación implementada en `Procesamiento.cs`.
2. Los nombres de canales en `separar_capas.py` deben validarse visualmente porque OpenCV trabaja internamente en BGR y las variables del script utilizan nombres que pueden inducir a confusión.
3. La aplicación requiere que el ejecutable encuentre Python mediante el comando `python` del sistema.
4. El almacenamiento de la imagen como una matriz JSON puede ocupar más espacio que almacenar el archivo comprimido.
5. La validación del correo es básica y no comprueba todos los formatos posibles.
6. El script de segmentación verde y azul debería verificar que `cv2.imread` no devuelva `None` antes de acceder a la imagen.
7. Conviene agregar una validación para evitar nombres de usuario duplicados.
8. Se recomienda agregar una opción para regresar del formulario de procesamiento al menú sin cerrar el menú principal.

## 12. Conclusión

ImagesVisualizer integra una interfaz de escritorio, una base de datos relacional y scripts de visión artificial. El flujo principal permite registrar e identificar usuarios, seleccionar o capturar imágenes, conservar una representación de la imagen en MySQL y aplicar transformaciones de color con OpenCV.

Las pruebas demuestran que el sistema puede generar imágenes en escala de grises, HSV y máscaras de colores, además de separar la imagen en capas. El proyecto cumple con el objetivo de mostrar un flujo básico de adquisición, almacenamiento y procesamiento digital de imágenes.

## 13. Guion breve para exposición

1. Presentar el objetivo del sistema.
2. Mostrar el registro de un usuario.
3. Explicar que la contraseña se almacena con BCrypt.
4. Iniciar sesión.
5. Cargar una fotografía desde el equipo.
6. Mostrar la opción de cámara web.
7. Guardar la matriz RGB en MySQL.
8. Abrir **Procesar Imagen**.
9. Ejecutar escala de grises, HSV y separación de capas.
10. Mostrar las imágenes resultantes.
11. Explicar las limitaciones y mejoras futuras.
