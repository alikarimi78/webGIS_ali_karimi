# importing library : 
    
import geopandas as gpd
import matplotlib.pyplot as plt
import tkinter as tk
from tkinter import filedialog as fd

# build class :

class Reading_geojson:
    
    def __init__(self, file_path):
        self.file_path = file_path
        
        # reading GeoJSON file by geopanda library :
            
        self.geojson_data_frame = gpd.read_file(self.file_path)
        
        # plotting :
        
        self.geojson_data_frame.plot()
        plt.xlabel('E')
        plt.ylabel('N')

# using class in main body: 
    
Page = tk.Tk()
file_path = fd.askopenfilename(title="Select GeoJSON file: ", filetypes=(("all files", "*.*"),("JSON Files", "*.json"),("GeoJSON Files", "*.geojson")))
Page.destroy()

if (file_path[-8:] == ".geojson" or file_path[-5:] == ".json" ):
    Reading_geojson(file_path)    
else :
    print("please choose a GeoJSON file! ")
    