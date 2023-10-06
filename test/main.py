from re import template
from flask import Flask, render_template, request, redirect, url_for, session
import sqlite3






app = Flask(__name__)

app.static_folder = 'static' 
app.template_folder = 'templates'






# Hàm factory để tạo ứng dụng cho từng luồng
def create_app():

    # Kết nối đến cơ sở dữ liệu
    conn = sqlite3.connect('user_data.db')
    cursor = conn.cursor()

    return app, conn, cursor






@app.route('/trangchu', methods=['GET', 'POST'])
def trangchu():
    app, conn, cursor = create_app()
    conn.close()
    return render_template('trangchu.html')




if __name__ == '__main__':
    #app, conn, cursor = create_app()  # Tạo ứng dụng và đối tượng kết nối
    
    app.run(debug=True)