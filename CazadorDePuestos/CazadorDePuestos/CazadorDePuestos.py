import time
import os
from selenium import webdriver
from selenium.webdriver.firefox.firefox_binary import FirefoxBinary
import sys
reload(sys)
sys.setdefaultencoding('utf-8')

binary = FirefoxBinary(r'C:\Program Files (x86)\Mozilla Firefox\firefox.exe')
driver = webdriver.Firefox(firefox_binary=binary)


#Control de Silencio
#driver.set_window_size(100,100)

#Urls a scrapear

Url1 = "https://www.indeed.com.mx/"
Url2 = "https://www.indeed.com.mx/"
Url3 = "https://www.indeed.com.mx/"


#Estado de donde se quiere buscar 

Estado = "Saltillo, Coahuila"

#Puesto que quieres buscar

Puesto = "Sistemas"

driver.get(Url1)

driver.find_element_by_id('where')
driver.find_element_by_id('where').clear()
driver.find_element_by_id('where').send_keys(Estado)
driver.find_element_by_id('what')
driver.find_element_by_id('what').clear()
driver.find_element_by_id('what').send_keys(Puesto)
driver.find_element_by_xpath('//*[@id="fj"]')
driver.find_element_by_xpath('//*[@id="fj"]').click()
driver.switch_to_default_content()
ScrapList = driver.find_elements_by_xpath("//*[@href]")
ScrapDes = driver.find_elements_by_xpath('//*[@id="pj_ab6bf32b81f98bdc"]/x:table/x:tbody/x:tr/x:td/x:span')



with open('C:\\Users\\LDELAROSA\\Documents\\Python\\Scrape\\ScrapedList.txt', "a") as f:
    for el in ScrapList:                 
       f.write(el.text+"\n")

time.sleep(5)
