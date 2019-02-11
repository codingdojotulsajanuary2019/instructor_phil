from flask import Flask, render_template, session, redirect, request
import random

app = Flask(__name__)
app.secret_key = 'my super secret key'

leaders = []

@app.route('/')
def index():
    # save a random number in session
    if 'ran_num' not in session:
        session['ran_num'] = random.randint(1, 100) 
        session['result'] = None
        session['count'] = 5
        session['leaders'] = []
    
    if session['count'] == 0 and session['result'] != 'Just Right':
        session['result'] = 'You lose'

    return render_template('index.html', leaders = leaders)

@app.route('/play_again')
def play_again():
    session.clear()
    return redirect('/')

@app.route('/process', methods=['post'])
def process():
    print('-'*90)
    print(type(request.form['guess']))
    print(type(session['ran_num']))
    server_num = session['ran_num']
    guess = int(request.form['guess'])
    session['count'] -= 1
    print(request.form['guess'])

    if server_num > guess:
        print('too low')
        session['result'] = 'Too Low'
        session['class'] = 'is-danger'
    elif server_num < guess:
        print('too high')
        session['result'] = 'Too High'
        session['class'] = 'is-danger'
    elif server_num:
        print('just right')
        session['result'] = "Just Right"
        session['class'] = 'is-success'

    return redirect('/')

@app.route('/winner_circle', methods=['post'])
def winner_circle():
    name = request.form['name']
    amount_of_guesses = 5 - session['count']
    leaders.append({'name': name, 'amount_of_guesses': amount_of_guesses})
    session.clear();
    return redirect('/')

if __name__ == '__main__':
    app.run(debug=True)