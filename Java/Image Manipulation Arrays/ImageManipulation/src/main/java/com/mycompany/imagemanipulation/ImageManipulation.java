
package com.mycompany.imagemanipulation;

/**
 *
 * @author John
 */

import java.awt.Color;
import java.awt.image.BufferedImage;
import java.io.File;
import java.net.URL;
import java.util.Arrays;
import java.util.Random;
import javax.imageio.ImageIO;
public class ImageManipulation {
	public static void main(String[] args) {
  
		int[][] imageData = imgToTwoD("./apple.jpg");

		//int[][] imageData = imgToTwoD("insert pic http link ");
		//viewImageData(imageData);
		int[][] trimmed = trimBorders(imageData, 60);
		twoDToImage(trimmed, "./trimmed_apple.jpg");

    int[][] negativeImg = negativeColor(imageData);
    twoDToImage(negativeImg, "./neg_apple.jpg");

    int[][] stretchHorizontal = stretchHorizontally(imageData);
    twoDToImage(stretchHorizontal, "./stretch_horizontal_apple.jpg");

    int[][] shrinkVert = shrinkVertically(imageData);
    twoDToImage(shrinkVert, "./shrink_vertical_apple.jpg");

    int[][] invertedImg = invertImage(imageData);
    twoDToImage(invertedImg, "./inverted_apple.jpg");

    int[][] imageColorFiltered = colorFilter(imageData, -25, 35, 60);
    twoDToImage(imageColorFiltered, "./colored_apple.jpg");

	 int[][] allFilters = stretchHorizontally(shrinkVertically(colorFilter(negativeColor(trimBorders(invertImage(imageData), 50)), 200, 20, 40)));

		// Painting with pixels

    int[][] blankCanvas = new int[500][500];
    int[][] randImage = paintRandomImage(blankCanvas);
    twoDToImage(randImage, "./random_image.jpg");

    int[] sqColor = {185, 255, 75, 255};
    int[][] rectangleImage = paintRectangle(randImage, 200, 200, 150, 150, getColorIntValFromRGBA(sqColor));
    twoDToImage(rectangleImage, "./rectangle_img.jpg");

    
    int[][] generatedRectangles = generateRectangles(randImage, 1000);
		twoDToImage(generatedRectangles, "./random_rect.jpg");
	}
	// Image Processing Methods
	public static int[][] trimBorders(int[][] imageTwoD, int pixelCount) {

		if (imageTwoD.length > pixelCount * 2 && imageTwoD[0].length > pixelCount * 2) {
			int[][] trimmedImg = new int[imageTwoD.length - pixelCount * 2][imageTwoD[0].length - pixelCount * 2];
			for (int i = 0; i < trimmedImg.length; i++) {
				for (int j = 0; j < trimmedImg[i].length; j++) {
					trimmedImg[i][j] = imageTwoD[i + pixelCount][j + pixelCount];
				}
			}
			return trimmedImg;
		} else {
			System.out.println("Cannot trim that many pixels from the given image.");
			return imageTwoD;
		}
	}
	public static int[][] negativeColor(int[][] imageTwoD) {

    int[][] negativeImage = new int[imageTwoD.length][imageTwoD[0].length];
    for(int i = 0; i < imageTwoD.length; i++){
      for (int j = 0; j < imageTwoD[i].length; j++){
      int[] rgba = getRGBAFromPixel(imageTwoD[i][j]);
      rgba[0] = 255-rgba[0];
      rgba[1] = 255-rgba[1];
      rgba[2] = 255-rgba[2];
      negativeImage[i][j] = getColorIntValFromRGBA(rgba);
      }
    }
		return negativeImage;
	}
	public static int[][] stretchHorizontally(int[][] imageTwoD) {

    int[][] stretchImage = new int[imageTwoD.length][imageTwoD[0].length * 2];
    int it;
    for(int i = 0; i < imageTwoD.length; i++){
      for (int j = 0; j< imageTwoD[i].length; j++){
        it = j*2;
        stretchImage[i][it] = imageTwoD[i][j];
        stretchImage[i][it+1] = imageTwoD[i][j];
      }
    }
		return stretchImage;
	}
	public static int[][] shrinkVertically(int[][] imageTwoD) {

    int[][] vertShrink = new int[imageTwoD.length / 2][imageTwoD[0].length];
    for (int i = 0; i < imageTwoD[0].length; i++){
      for (int j = 0; j < imageTwoD.length - 1; j++){
        vertShrink[j/2][i] = imageTwoD[j][i];
      }
    }
		return vertShrink;
	}
	public static int[][] invertImage(int[][] imageTwoD) {

    int[][] invertedImage = new int[imageTwoD.length][imageTwoD[0].length];
    for (int i = 0; i < imageTwoD.length; i++){
      for(int j = 0; j < imageTwoD[i].length; j++){
        invertedImage[i][j] = imageTwoD[(imageTwoD.length-1) - i][(imageTwoD[i].length -1) - j];
      }
    }
		return invertedImage;
	}
	public static int[][] colorFilter(int[][] imageTwoD, int redChangeValue, int greenChangeValue, int blueChangeValue) {
	
  int[][] filteredImage = new int[imageTwoD.length][imageTwoD[0].length];
  for(int i = 0; i< imageTwoD.length; i++){
    for(int j = 0; j < imageTwoD[i].length; j++){
      int[] rgba = getRGBAFromPixel(imageTwoD[i][j]);
      int red = rgba[0] + redChangeValue;
      int green = rgba[1] + greenChangeValue;
      int blue = rgba[2] + blueChangeValue;
      
      if(red > 255){
        red = 255;
      }else if (red < 0){
        red = 0;
      }
      if(green > 255){
        green = 255;
      }else if (green < 0){
        green = 0;
      }
      if(blue > 255){
        blue = 255;
      }else if (blue < 0){
        blue = 0;
      }

      rgba[0] = red;
      rgba[1] = green;
      rgba[2] = blue;
    filteredImage[i][j] = getColorIntValFromRGBA(rgba);
    }
  }
		return filteredImage;
	}

	// Painting Methods
	public static int[][] paintRandomImage(int[][] canvas) {
		Random rand = new Random();
    for(int i = 0; i < canvas.length; i++){
      for(int j = 0; j< canvas[i].length; j++){
        int randRed = rand.nextInt(256);
        int randGreen = rand.nextInt(256);
        int randBlue = rand.nextInt(256);
        int[] rgbVal = {randRed, randGreen, randBlue, 255};
        canvas[i][j] = getColorIntValFromRGBA(rgbVal);
      }
    }
		return canvas;
	}
	public static int[][] paintRectangle(int[][] canvas, int width, int height, int rowPosition, int colPosition, int color) {
		for(int i = 0; i < canvas.length; i++){
      for(int j = 0; j< canvas[i].length; j++){
          if(i >= rowPosition && i <= rowPosition + width){
            if(j >= colPosition && j <= colPosition + height){
              canvas[i][j] = color;
            }
          }
        }
      }
		return canvas;
	}
	public static int[][] generateRectangles(int[][] canvas, int numRectangles) {
		// TODO: Fill in the code for this method
    Random rand = new Random();

    for(int i = 0; i<numRectangles; i++) {
      int height = rand.nextInt(canvas.length);
      int width = rand.nextInt(canvas[0].length);
      int randRowPosition = rand.nextInt(canvas.length-height);
      int randColumnPosition = rand.nextInt(canvas[0].length - width);
      int randRed = rand.nextInt(256);
      int randGreen = rand.nextInt(256);
      int randBlue = rand.nextInt(256);
      int[] rgbVal = {randRed, randGreen, randBlue, 255};
      int randColor = getColorIntValFromRGBA(rgbVal);

      canvas = paintRectangle(canvas, width, height, randRowPosition, randColumnPosition, randColor);
  }
		return canvas;
	}
	// Utility Methods
	public static int[][] imgToTwoD(String inputFileOrLink) {
		try {
			BufferedImage image = null;
			if (inputFileOrLink.substring(0, 4).toLowerCase().equals("http")) {
				URL imageUrl = new URL(inputFileOrLink);
				image = ImageIO.read(imageUrl);
				if (image == null) {
					System.out.println("Failed to get image from provided URL.");
				}
			} else {
				image = ImageIO.read(new File(inputFileOrLink));
			}
			int imgRows = image.getHeight();
			int imgCols = image.getWidth();
			int[][] pixelData = new int[imgRows][imgCols];
			for (int i = 0; i < imgRows; i++) {
				for (int j = 0; j < imgCols; j++) {
					pixelData[i][j] = image.getRGB(j, i);
				}
			}
			return pixelData;
		} catch (Exception e) {
			System.out.println("Failed to load image: " + e.getLocalizedMessage());
			return null;
		}
	}
	public static void twoDToImage(int[][] imgData, String fileName) {
		try {
			int imgRows = imgData.length;
			int imgCols = imgData[0].length;
			BufferedImage result = new BufferedImage(imgCols, imgRows, BufferedImage.TYPE_INT_RGB);
			for (int i = 0; i < imgRows; i++) {
				for (int j = 0; j < imgCols; j++) {
					result.setRGB(j, i, imgData[i][j]);
				}
			}
			File output = new File(fileName);
			ImageIO.write(result, "jpg", output);
		} catch (Exception e) {
			System.out.println("Failed to save image: " + e.getLocalizedMessage());
		}
	}
	public static int[] getRGBAFromPixel(int pixelColorValue) {
		Color pixelColor = new Color(pixelColorValue);
		return new int[] { pixelColor.getRed(), pixelColor.getGreen(), pixelColor.getBlue(), pixelColor.getAlpha() };
	}
	public static int getColorIntValFromRGBA(int[] colorData) {
		if (colorData.length == 4) {
			Color color = new Color(colorData[0], colorData[1], colorData[2], colorData[3]);
			return color.getRGB();
		} else {
			System.out.println("Incorrect number of elements in RGBA array.");
			return -1;
		}
	}
	public static void viewImageData(int[][] imageTwoD) {
		if (imageTwoD.length > 3 && imageTwoD[0].length > 3) {
			int[][] rawPixels = new int[3][3];
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					rawPixels[i][j] = imageTwoD[i][j];
				}
			}
			System.out.println("Raw pixel data from the top left corner.");
			System.out.print(Arrays.deepToString(rawPixels).replace("],", "],\n") + "\n");
			int[][][] rgbPixels = new int[3][3][4];
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					rgbPixels[i][j] = getRGBAFromPixel(imageTwoD[i][j]);
				}
			}
			System.out.println();
			System.out.println("Extracted RGBA pixel data from top the left corner.");
			for (int[][] row : rgbPixels) {
				System.out.print(Arrays.deepToString(row) + System.lineSeparator());
			}
		} else {
			System.out.println("The image is not large enough to extract 9 pixels from the top left corner");
		}
	}
}