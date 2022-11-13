import React, {useState} from 'react';
import { BsFillPlayFill, BsPauseFill } from 'react-icons/bs'
import { meal } from '../../constants'
import './Intro.css';

const Intro = () => {
  const [playVideo, setPlayVideo] = useState(false)
  const vidRef = React.useRef();

const handleVideo = () => {
  //negate playvideo by calling its previous state and negating
  setPlayVideo((prevPlayVideo) => !prevPlayVideo)

  if (playVideo){
    vidRef.current.pause()
  } else{
    vidRef.current.play()
  }
}

return (
  <div className='app__video'>
    <video src={meal}
           ref={vidRef}
           type='video/mp4'
           loop
           controls={false}
           muted 
           />
    <div className='app__video-overlay flex__center'>
      <div className='app__video-overlay-circle flex__center'
           onClick={handleVideo}>

          {/*if playvideo is true render pausefill, if false render playfill*/}
          {playVideo 
          ? <BsPauseFill color='#fff' fontSize={30}/> 
          : <BsFillPlayFill color='#fff' fontSize={30}/>}
      </div>
    </div>
  </div>
  )
  
}

export default Intro;
