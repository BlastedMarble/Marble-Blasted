<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/09/03 02:24:09">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="7">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="11" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="13">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="-16 38 3.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 38 3.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="3 27 23" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="-11 27 23" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="3 27 23" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="0" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="-16 60 -15.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="-16 28 -15.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="225">
                    <Brush id="0" owner="0" type="0" pos="0 1 -16" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 1 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 11 20" />
                            <Vertex pos="12 11 -20" />
                            <Vertex pos="12 -11 20" />
                            <Vertex pos="12 -11 -20" />
                            <Vertex pos="-10 11 20" />
                            <Vertex pos="-10 11 -20" />
                            <Vertex pos="-10 -11 20" />
                            <Vertex pos="-10 -11 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-8 0 12" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 12 8" />
                            <Vertex pos="4 12 -8" />
                            <Vertex pos="4 -12 8" />
                            <Vertex pos="4 -12 -8" />
                            <Vertex pos="-4 12 8" />
                            <Vertex pos="-4 12 -8" />
                            <Vertex pos="-4 -12 8" />
                            <Vertex pos="-4 -12 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="8 0 12" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 0 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 12 8" />
                            <Vertex pos="4 12 -8" />
                            <Vertex pos="4 -12 8" />
                            <Vertex pos="4 -12 -8" />
                            <Vertex pos="-4 12 8" />
                            <Vertex pos="-4 12 -8" />
                            <Vertex pos="-4 -12 8" />
                            <Vertex pos="-4 -12 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="0 -7 8" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -7 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 4" />
                            <Vertex pos="4 3 -4" />
                            <Vertex pos="4 -3 4" />
                            <Vertex pos="4 -3 -4" />
                            <Vertex pos="-4 3 4" />
                            <Vertex pos="-4 3 -4" />
                            <Vertex pos="-4 -3 4" />
                            <Vertex pos="-4 -3 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1152 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 640 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="0 8 16" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 4" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 4" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="-4 4 4" />
                            <Vertex pos="-4 4 -4" />
                            <Vertex pos="-4 -4 4" />
                            <Vertex pos="-4 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-16 76 -16" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 76 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 12 20" />
                            <Vertex pos="10 12 -20" />
                            <Vertex pos="10 -12 20" />
                            <Vertex pos="10 -12 -20" />
                            <Vertex pos="-12 12 20" />
                            <Vertex pos="-12 12 -20" />
                            <Vertex pos="-12 -12 20" />
                            <Vertex pos="-12 -12 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-8 76 8" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 76 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 12 4" />
                            <Vertex pos="2 12 -4" />
                            <Vertex pos="2 -12 4" />
                            <Vertex pos="2 -12 -4" />
                            <Vertex pos="-4 12 4" />
                            <Vertex pos="-4 12 -4" />
                            <Vertex pos="-4 -12 4" />
                            <Vertex pos="-4 -12 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-20 84 8" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 84 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 4 4" />
                            <Vertex pos="8 4 -4" />
                            <Vertex pos="8 -4 4" />
                            <Vertex pos="8 -4 -4" />
                            <Vertex pos="-6 4 4" />
                            <Vertex pos="-6 4 -4" />
                            <Vertex pos="-6 -4 4" />
                            <Vertex pos="-6 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-24 68 8" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 68 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 4" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 4" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="-2 4 4" />
                            <Vertex pos="-2 4 -4" />
                            <Vertex pos="-2 -4 4" />
                            <Vertex pos="-2 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-8 76 16" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 76 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 12 4" />
                            <Vertex pos="4 12 -4" />
                            <Vertex pos="4 -12 4" />
                            <Vertex pos="4 -12 -4" />
                            <Vertex pos="-4 12 4" />
                            <Vertex pos="-4 12 -4" />
                            <Vertex pos="-4 -12 4" />
                            <Vertex pos="-4 -12 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-21 48 2" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 48 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 16 4" />
                            <Vertex pos="1 16 -4" />
                            <Vertex pos="1 -16 4" />
                            <Vertex pos="1 -16 -4" />
                            <Vertex pos="-1 16 4" />
                            <Vertex pos="-1 16 -4" />
                            <Vertex pos="-1 -16 4" />
                            <Vertex pos="-1 -16 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-11 53 5" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 53 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 11 7" />
                            <Vertex pos="1 11 -7" />
                            <Vertex pos="1 -11 7" />
                            <Vertex pos="1 -11 -7" />
                            <Vertex pos="-1 11 7" />
                            <Vertex pos="-1 11 -7" />
                            <Vertex pos="-1 -11 7" />
                            <Vertex pos="-1 -11 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-16 48 13" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 48 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 16 1" />
                            <Vertex pos="6 16 -1" />
                            <Vertex pos="6 -16 1" />
                            <Vertex pos="6 -16 -1" />
                            <Vertex pos="-6 16 1" />
                            <Vertex pos="-6 16 -1" />
                            <Vertex pos="-6 -16 1" />
                            <Vertex pos="-6 -16 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-16 54 -3" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 54 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 10 1" />
                            <Vertex pos="6 10 -1" />
                            <Vertex pos="6 -10 1" />
                            <Vertex pos="6 -10 -1" />
                            <Vertex pos="-6 10 1" />
                            <Vertex pos="-6 10 -1" />
                            <Vertex pos="-6 -10 1" />
                            <Vertex pos="-6 -10 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-5 23 2" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 23 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 11 4" />
                            <Vertex pos="1 11 -4" />
                            <Vertex pos="1 -11 4" />
                            <Vertex pos="1 -11 -4" />
                            <Vertex pos="-1 11 4" />
                            <Vertex pos="-1 11 -4" />
                            <Vertex pos="-1 -11 4" />
                            <Vertex pos="-1 -11 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 1664 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -2176 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="5 28 5" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 28 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 16 7" />
                            <Vertex pos="1 16 -7" />
                            <Vertex pos="1 -16 7" />
                            <Vertex pos="1 -16 -7" />
                            <Vertex pos="-1 16 7" />
                            <Vertex pos="-1 16 -7" />
                            <Vertex pos="-1 -16 7" />
                            <Vertex pos="-1 -16 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -2816 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="0 28 13" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 28 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 16 1" />
                            <Vertex pos="6 16 -1" />
                            <Vertex pos="6 -16 1" />
                            <Vertex pos="6 -16 -1" />
                            <Vertex pos="-6 16 1" />
                            <Vertex pos="-6 16 -1" />
                            <Vertex pos="-6 -16 1" />
                            <Vertex pos="-6 -16 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 2304 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -2816 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="0 22 -3" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 22 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 10 1" />
                            <Vertex pos="6 10 -1" />
                            <Vertex pos="6 -10 1" />
                            <Vertex pos="6 -10 -1" />
                            <Vertex pos="-6 10 1" />
                            <Vertex pos="-6 10 -1" />
                            <Vertex pos="-6 -10 1" />
                            <Vertex pos="-6 -10 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 1536 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -2048 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1536 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-8 38 -3" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 38 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14 6 1" />
                            <Vertex pos="14 6 -1" />
                            <Vertex pos="14 -6 1" />
                            <Vertex pos="14 -6 -1" />
                            <Vertex pos="-14 6 1" />
                            <Vertex pos="-14 6 -1" />
                            <Vertex pos="-14 -6 1" />
                            <Vertex pos="-14 -6 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -14" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -14" album="" material="bm_grid_blank4" texgens="0 -1 0 -1536 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -2560 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -2560 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 2048 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-13 33 2" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 33 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 1 4" />
                            <Vertex pos="7 1 -4" />
                            <Vertex pos="7 -1 4" />
                            <Vertex pos="7 -1 -4" />
                            <Vertex pos="-7 1 4" />
                            <Vertex pos="-7 1 -4" />
                            <Vertex pos="-7 -1 4" />
                            <Vertex pos="-7 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-1 43 5" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 43 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 1 7" />
                            <Vertex pos="5 1 -7" />
                            <Vertex pos="5 -1 7" />
                            <Vertex pos="5 -1 -7" />
                            <Vertex pos="-5 1 7" />
                            <Vertex pos="-5 1 -7" />
                            <Vertex pos="-5 -1 7" />
                            <Vertex pos="-5 -1 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-16 62 1" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 62 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 3" />
                            <Vertex pos="4 2 -3" />
                            <Vertex pos="4 -2 3" />
                            <Vertex pos="4 -2 -3" />
                            <Vertex pos="-4 2 3" />
                            <Vertex pos="-4 2 -3" />
                            <Vertex pos="-4 -2 3" />
                            <Vertex pos="-4 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -1536 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-16 47 1" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 47 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 5 3" />
                            <Vertex pos="4 5 -3" />
                            <Vertex pos="4 -5 3" />
                            <Vertex pos="4 -5 -3" />
                            <Vertex pos="-4 5 3" />
                            <Vertex pos="-4 5 -3" />
                            <Vertex pos="-4 -5 3" />
                            <Vertex pos="-4 -5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -1408 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="0 31 1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 31 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 3" />
                            <Vertex pos="4 3 -3" />
                            <Vertex pos="4 -3 3" />
                            <Vertex pos="4 -3 -3" />
                            <Vertex pos="-4 3 3" />
                            <Vertex pos="-4 3 -3" />
                            <Vertex pos="-4 -3 3" />
                            <Vertex pos="-4 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-8 43 1" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 43 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 3" />
                            <Vertex pos="2 1 -3" />
                            <Vertex pos="2 -1 3" />
                            <Vertex pos="2 -1 -3" />
                            <Vertex pos="-2 1 3" />
                            <Vertex pos="-2 1 -3" />
                            <Vertex pos="-2 -1 3" />
                            <Vertex pos="-2 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-8 43 9" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 43 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 3" />
                            <Vertex pos="2 1 -3" />
                            <Vertex pos="2 -1 3" />
                            <Vertex pos="2 -1 -3" />
                            <Vertex pos="-2 1 3" />
                            <Vertex pos="-2 1 -3" />
                            <Vertex pos="-2 -1 3" />
                            <Vertex pos="-2 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-21 60 9" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 60 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 3" />
                            <Vertex pos="1 4 -3" />
                            <Vertex pos="1 -4 3" />
                            <Vertex pos="1 -4 -3" />
                            <Vertex pos="-1 4 3" />
                            <Vertex pos="-1 4 -3" />
                            <Vertex pos="-1 -4 3" />
                            <Vertex pos="-1 -4 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-21 40 9" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 40 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 3" />
                            <Vertex pos="1 8 -3" />
                            <Vertex pos="1 -8 3" />
                            <Vertex pos="1 -8 -3" />
                            <Vertex pos="-1 8 3" />
                            <Vertex pos="-1 8 -3" />
                            <Vertex pos="-1 -8 3" />
                            <Vertex pos="-1 -8 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-21 52 11" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 52 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 1" />
                            <Vertex pos="1 4 -1" />
                            <Vertex pos="1 -4 1" />
                            <Vertex pos="1 -4 -1" />
                            <Vertex pos="-1 4 1" />
                            <Vertex pos="-1 4 -1" />
                            <Vertex pos="-1 -4 1" />
                            <Vertex pos="-1 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-19 33 9" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 33 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 3" />
                            <Vertex pos="1 1 -3" />
                            <Vertex pos="1 -1 3" />
                            <Vertex pos="1 -1 -3" />
                            <Vertex pos="-1 1 3" />
                            <Vertex pos="-1 1 -3" />
                            <Vertex pos="-1 -1 3" />
                            <Vertex pos="-1 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-10 33 9" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 33 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 3" />
                            <Vertex pos="4 1 -3" />
                            <Vertex pos="4 -1 3" />
                            <Vertex pos="4 -1 -3" />
                            <Vertex pos="-4 1 3" />
                            <Vertex pos="-4 1 -3" />
                            <Vertex pos="-4 -1 3" />
                            <Vertex pos="-4 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-16 33 11" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 33 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 1" />
                            <Vertex pos="2 1 -1" />
                            <Vertex pos="2 -1 1" />
                            <Vertex pos="2 -1 -1" />
                            <Vertex pos="-2 1 1" />
                            <Vertex pos="-2 1 -1" />
                            <Vertex pos="-2 -1 1" />
                            <Vertex pos="-2 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -896 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -768 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -768 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="0 14 1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 14 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 3" />
                            <Vertex pos="4 2 -3" />
                            <Vertex pos="4 -2 3" />
                            <Vertex pos="4 -2 -3" />
                            <Vertex pos="-4 2 3" />
                            <Vertex pos="-4 2 -3" />
                            <Vertex pos="-4 -2 3" />
                            <Vertex pos="-4 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-32 76 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 76 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-40 72 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 72 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 0.5" />
                            <Vertex pos="4 8 -0.5" />
                            <Vertex pos="4 -8 0.5" />
                            <Vertex pos="4 -8 -0.5" />
                            <Vertex pos="-4 8 0.5" />
                            <Vertex pos="-4 8 -0.5" />
                            <Vertex pos="-4 -8 0.5" />
                            <Vertex pos="-4 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-14 14 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 14 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 0 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-14 8 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 8 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_stripe_caution1" texgens="0 -1 1 -3008 0 0 -1 1984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_stripe_caution1" texgens="1 0 1 -3776 0 0 -1 1984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_mud" texgens="1 0 0 -3584 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-6 -16 -14.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -16 0 0 1 -14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 4 0.5" />
                            <Vertex pos="10 4 -0.5" />
                            <Vertex pos="10 -4 0.5" />
                            <Vertex pos="10 -4 -0.5" />
                            <Vertex pos="-10 4 0.5" />
                            <Vertex pos="-10 4 -0.5" />
                            <Vertex pos="-10 -4 0.5" />
                            <Vertex pos="-10 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1792 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 1536 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-8 -11 -16" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -11 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 20" />
                            <Vertex pos="4 1 -20" />
                            <Vertex pos="4 -1 20" />
                            <Vertex pos="4 -1 -20" />
                            <Vertex pos="-4 1 20" />
                            <Vertex pos="-4 1 -20" />
                            <Vertex pos="-4 -1 20" />
                            <Vertex pos="-4 -1 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile07_D" texgens="1 0 0 -4608 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="8 -11 -16" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -11 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 20" />
                            <Vertex pos="4 1 -20" />
                            <Vertex pos="4 -1 20" />
                            <Vertex pos="4 -1 -20" />
                            <Vertex pos="-4 1 20" />
                            <Vertex pos="-4 1 -20" />
                            <Vertex pos="-4 -1 20" />
                            <Vertex pos="-4 -1 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile07_D" texgens="1 0 0 -4608 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="0 -11 -25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -11 0 0 1 -25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 11" />
                            <Vertex pos="4 1 -11" />
                            <Vertex pos="4 -1 11" />
                            <Vertex pos="4 -1 -11" />
                            <Vertex pos="-4 1 11" />
                            <Vertex pos="-4 1 -11" />
                            <Vertex pos="-4 -1 11" />
                            <Vertex pos="-4 -1 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="8.25 0 20.5" rot="1 0 0 0" scale="" transform="1 0 0 8.25 0 1 0 0 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 12.5 0.5" />
                            <Vertex pos="4.25 12.5 -0.5" />
                            <Vertex pos="4.25 -12.5 0.5" />
                            <Vertex pos="4.25 -12.5 -0.5" />
                            <Vertex pos="-4.25 12.5 0.5" />
                            <Vertex pos="-4.25 12.5 -0.5" />
                            <Vertex pos="-4.25 -12.5 0.5" />
                            <Vertex pos="-4.25 -12.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 1 0 3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1088 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12.5" album="" material="bm_grid_blank3" texgens="1 0 0 -832 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -832 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1088 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="0 15 21.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 15 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 11 0.5" />
                            <Vertex pos="4 11 -0.5" />
                            <Vertex pos="4 -11 0.5" />
                            <Vertex pos="4 -11 -0.5" />
                            <Vertex pos="-4 11 0.5" />
                            <Vertex pos="-4 11 -0.5" />
                            <Vertex pos="-4 -11 0.5" />
                            <Vertex pos="-4 -11 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-4 27 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 27 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -1536 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-16 61 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 61 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 11 0.5" />
                            <Vertex pos="4 11 -0.5" />
                            <Vertex pos="4 -11 0.5" />
                            <Vertex pos="4 -11 -0.5" />
                            <Vertex pos="-4 11 0.5" />
                            <Vertex pos="-4 11 -0.5" />
                            <Vertex pos="-4 -11 0.5" />
                            <Vertex pos="-4 -11 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -11" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="-8 38 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 38 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="-24 76 16" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 76 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 12 4" />
                            <Vertex pos="4 12 -4" />
                            <Vertex pos="4 -12 4" />
                            <Vertex pos="4 -12 -4" />
                            <Vertex pos="-2 12 4" />
                            <Vertex pos="-2 12 -4" />
                            <Vertex pos="-2 -12 4" />
                            <Vertex pos="-2 -12 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="-16 68 16" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 68 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 4" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 4" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="-4 4 4" />
                            <Vertex pos="-4 4 -4" />
                            <Vertex pos="-4 -4 4" />
                            <Vertex pos="-4 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="-16 84 16" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 84 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 4" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 4" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="-4 4 4" />
                            <Vertex pos="-4 4 -4" />
                            <Vertex pos="-4 -4 4" />
                            <Vertex pos="-4 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="-16 76 13" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 76 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 1" />
                            <Vertex pos="4 4 -1" />
                            <Vertex pos="4 -4 1" />
                            <Vertex pos="4 -4 -1" />
                            <Vertex pos="-4 4 1" />
                            <Vertex pos="-4 4 -1" />
                            <Vertex pos="-4 -4 1" />
                            <Vertex pos="-4 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 768 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="-8.25 0 20.5" rot="1 0 0 0" scale="" transform="1 0 0 -8.25 0 1 0 0 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 12.5 0.5" />
                            <Vertex pos="4.25 12.5 -0.5" />
                            <Vertex pos="4.25 -12.5 0.5" />
                            <Vertex pos="4.25 -12.5 -0.5" />
                            <Vertex pos="-4.25 12.5 0.5" />
                            <Vertex pos="-4.25 12.5 -0.5" />
                            <Vertex pos="-4.25 -12.5 0.5" />
                            <Vertex pos="-4.25 -12.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 1 0 3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1216 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12.5" album="" material="bm_grid_blank3" texgens="1 0 0 -960 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -960 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1216 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="0 8.25 20.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8.25 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4.25 0.5" />
                            <Vertex pos="4 4.25 -0.5" />
                            <Vertex pos="4 -4.25 0.5" />
                            <Vertex pos="4 -4.25 -0.5" />
                            <Vertex pos="-4 4.25 0.5" />
                            <Vertex pos="-4 4.25 -0.5" />
                            <Vertex pos="-4 -4.25 0.5" />
                            <Vertex pos="-4 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 5312 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -5056 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 -1 0 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 -1 0 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="0 -8.25 20.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -8.25 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4.25 0.5" />
                            <Vertex pos="4 4.25 -0.5" />
                            <Vertex pos="4 -4.25 0.5" />
                            <Vertex pos="4 -4.25 -0.5" />
                            <Vertex pos="-4 4.25 0.5" />
                            <Vertex pos="-4 4.25 -0.5" />
                            <Vertex pos="-4 -4.25 0.5" />
                            <Vertex pos="-4 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 5440 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -5184 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 -1 0 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 -1 0 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-7.75 76 20.5" rot="1 0 0 0" scale="" transform="1 0 0 -7.75 0 1 0 76 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 12.5 0.5" />
                            <Vertex pos="4.25 12.5 -0.5" />
                            <Vertex pos="4.25 -12.5 0.5" />
                            <Vertex pos="4.25 -12.5 -0.5" />
                            <Vertex pos="-4.25 12.5 0.5" />
                            <Vertex pos="-4.25 12.5 -0.5" />
                            <Vertex pos="-4.25 -12.5 0.5" />
                            <Vertex pos="-4.25 -12.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 1 0 3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1088 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12.5" album="" material="bm_grid_blank3" texgens="1 0 0 -832 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -832 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1088 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-24.25 76 20.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 76 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 12.5 0.5" />
                            <Vertex pos="4.25 12.5 -0.5" />
                            <Vertex pos="4.25 -12.5 0.5" />
                            <Vertex pos="4.25 -12.5 -0.5" />
                            <Vertex pos="-4.25 12.5 0.5" />
                            <Vertex pos="-4.25 12.5 -0.5" />
                            <Vertex pos="-4.25 -12.5 0.5" />
                            <Vertex pos="-4.25 -12.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 1 0 3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1216 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12.5" album="" material="bm_grid_blank3" texgens="1 0 0 -960 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -960 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1216 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-16 84.25 20.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 84.25 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4.25 0.5" />
                            <Vertex pos="4 4.25 -0.5" />
                            <Vertex pos="4 -4.25 0.5" />
                            <Vertex pos="4 -4.25 -0.5" />
                            <Vertex pos="-4 4.25 0.5" />
                            <Vertex pos="-4 4.25 -0.5" />
                            <Vertex pos="-4 -4.25 0.5" />
                            <Vertex pos="-4 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 5312 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -5056 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 -1 0 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 -1 0 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-16 67.75 20.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 67.75 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4.25 0.5" />
                            <Vertex pos="4 4.25 -0.5" />
                            <Vertex pos="4 -4.25 0.5" />
                            <Vertex pos="4 -4.25 -0.5" />
                            <Vertex pos="-4 4.25 0.5" />
                            <Vertex pos="-4 4.25 -0.5" />
                            <Vertex pos="-4 -4.25 0.5" />
                            <Vertex pos="-4 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 5440 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -5184 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -640 0 -1 0 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 896 0 -1 0 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-16 84 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 84 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-16 92 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 92 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="0 92 3.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 92 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -512 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="0 76 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 76 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -512 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-4 60 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 60 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 4 0.5" />
                            <Vertex pos="8 4 -0.5" />
                            <Vertex pos="8 -4 0.5" />
                            <Vertex pos="8 -4 -0.5" />
                            <Vertex pos="-8 4 0.5" />
                            <Vertex pos="-8 4 -0.5" />
                            <Vertex pos="-8 -4 0.5" />
                            <Vertex pos="-8 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_trim" texgens="0 -1 0 -7680 0 0 -1 1984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 0 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="0 -11 16" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -11 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 4" />
                            <Vertex pos="4 1 -4" />
                            <Vertex pos="4 -1 4" />
                            <Vertex pos="4 -1 -4" />
                            <Vertex pos="-4 1 4" />
                            <Vertex pos="-4 1 -4" />
                            <Vertex pos="-4 -1 4" />
                            <Vertex pos="-4 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="0 -12.5 16" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -12.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 4" />
                            <Vertex pos="4 0.5 -4" />
                            <Vertex pos="4 -0.5 4" />
                            <Vertex pos="4 -0.5 -4" />
                            <Vertex pos="-4 0.5 4" />
                            <Vertex pos="-4 0.5 -4" />
                            <Vertex pos="-4 -0.5 4" />
                            <Vertex pos="-4 -0.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 320 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -512 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="0 -11 -12" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -11 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 2" />
                            <Vertex pos="4 1 -2" />
                            <Vertex pos="4 -1 2" />
                            <Vertex pos="4 -1 -2" />
                            <Vertex pos="-4 1 2" />
                            <Vertex pos="-4 1 -2" />
                            <Vertex pos="-4 -1 2" />
                            <Vertex pos="-4 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_tile04_D" texgens="1 0 0 -512 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-1 -11 -6" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 -11 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1152 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_tile04_D" texgens="1 0 0 -1280 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="0 -11 1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -11 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 1" />
                            <Vertex pos="2 1 -1" />
                            <Vertex pos="2 -1 1" />
                            <Vertex pos="2 -1 -1" />
                            <Vertex pos="-2 1 1" />
                            <Vertex pos="-2 1 -1" />
                            <Vertex pos="-2 -1 1" />
                            <Vertex pos="-2 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_tile04_D" texgens="1 0 0 -1536 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="1 -11 5" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -11 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1152 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_tile04_D" texgens="1 0 0 -1280 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1664 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="0 -11.5 10" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -11.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1.5 2" />
                            <Vertex pos="2 1.5 -2" />
                            <Vertex pos="2 -1.5 2" />
                            <Vertex pos="2 -0.5 -2" />
                            <Vertex pos="-2 1.5 2" />
                            <Vertex pos="-2 1.5 -2" />
                            <Vertex pos="-2 -1.5 2" />
                            <Vertex pos="-2 -0.5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -960 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 448 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.970142 -0.242536 -0.970143" album="" material="bm_tile04_D" texgens="1 0 0 -1536 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1792 0 -1 0 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 -1 0 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-40 62 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 62 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 1.5" />
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="4 -2 -1.5" />
                            <Vertex pos="-4 2 1.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                            <Vertex pos="-4 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-40 56 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 56 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_stripe_caution1" texgens="1 0 1 -4928 0 0 -1 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-40 44 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 44 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 1.5" />
                            <Vertex pos="4 2 0.499999" />
                            <Vertex pos="4 -2 -0.499999" />
                            <Vertex pos="4 -2 -1.5" />
                            <Vertex pos="-4 2 1.5" />
                            <Vertex pos="-4 2 0.499999" />
                            <Vertex pos="-4 -2 -0.499999" />
                            <Vertex pos="-4 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -3.8147e-006 -1.99999" album="" material="bm_stripe_caution1" texgens="-1 0 1 5440 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -7.62939e-006 -2.00001" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447213 0.894428 -0.447215" album="" material="bm_friction_ice" texgens="1 0 0 -10240 0 -1 0 -11264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-40 38 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 38 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -10240 0 -1 0 -9728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-40 32 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 32 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 -0.500001" />
                            <Vertex pos="4 2 -1.5" />
                            <Vertex pos="4 -2 1.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="-4 2 -0.500001" />
                            <Vertex pos="-4 2 -1.5" />
                            <Vertex pos="-4 -2 1.5" />
                            <Vertex pos="-4 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_stripe_caution1" texgens="1 0 1 -4800 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447213" album="" material="bm_friction_ice" texgens="1 0 0 -10240 0 -1 0 -8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447213" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-40 26 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 26 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 1.5" />
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="4 -2 -1.5" />
                            <Vertex pos="-4 2 1.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                            <Vertex pos="-4 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_stripe_caution1" texgens="-1 0 1 5440 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-40 20 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 20 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="-40 14 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 14 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 2 -1.5" />
                            <Vertex pos="4 -2 1.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 2 -1.5" />
                            <Vertex pos="-4 -2 1.5" />
                            <Vertex pos="-4 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447214" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="-40 4 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 4 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 8 0.5" />
                            <Vertex pos="4 8 -0.5" />
                            <Vertex pos="4 -8 0.5" />
                            <Vertex pos="4 -8 -0.5" />
                            <Vertex pos="-4 8 0.5" />
                            <Vertex pos="-4 8 -0.5" />
                            <Vertex pos="-4 -8 0.5" />
                            <Vertex pos="-4 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-4 29 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 29 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -1024 0 -1 0 -7424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="-4 31 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 31 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -1536 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-4 33 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 33 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -1024 0 -1 0 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-4 35 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 35 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -1536 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="-12 41 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 41 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -3072 0 -1 0 -10496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="-12 43 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 43 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -1536 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-12 45 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 45 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -3072 0 -1 0 -11520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-12 47 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 47 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile04_D" texgens="1 0 0 -1536 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-12 49 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 49 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 0.5" />
                            <Vertex pos="8 1 -0.5" />
                            <Vertex pos="8 -1 0.5" />
                            <Vertex pos="8 -1 -0.5" />
                            <Vertex pos="-8 1 0.5" />
                            <Vertex pos="-8 1 -0.5" />
                            <Vertex pos="-8 -1 0.5" />
                            <Vertex pos="-8 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -3072 0 -1 0 -12544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-16 53 4" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 53 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.999996 0.999999" />
                            <Vertex pos="4 0.999996 0" />
                            <Vertex pos="4 -1 0" />
                            <Vertex pos="4 -1 -0.999999" />
                            <Vertex pos="-4 0.999996 0.999999" />
                            <Vertex pos="-4 0.999996 0" />
                            <Vertex pos="-4 -1 0" />
                            <Vertex pos="-4 -1 -0.999999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.999996" album="" material="bm_stripe_caution1" texgens="-1 0 1 2560 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447212" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-16 59 4" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 59 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 -9.53674e-007" />
                            <Vertex pos="4 1 -0.999998" />
                            <Vertex pos="4 -0.999996 0.999998" />
                            <Vertex pos="4 -0.999996 1.19209e-006" />
                            <Vertex pos="-4 1 -9.53674e-007" />
                            <Vertex pos="-4 1 -0.999998" />
                            <Vertex pos="-4 -0.999996 0.999998" />
                            <Vertex pos="-4 -0.999996 1.19209e-006" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.999996" album="" material="bm_stripe_caution1" texgens="1 0 1 -1536 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447213" album="" material="bm_friction_grass" texgens="1 0 0 -4096 0 -1 0 -15104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447211" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="3 22 3" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 22 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 1" />
                            <Vertex pos="1 6 0" />
                            <Vertex pos="1 -6 1" />
                            <Vertex pos="1 -6 0" />
                            <Vertex pos="-1 6 0" />
                            <Vertex pos="-1 6 -1" />
                            <Vertex pos="-1 -6 0" />
                            <Vertex pos="-1 -6 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_stripe_caution1" texgens="0 -1 1 -2432 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.447214" album="" material="bm_friction_grass" texgens="1 0 0 768 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-3 22 3" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 22 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0" />
                            <Vertex pos="1 6 -1" />
                            <Vertex pos="1 -6 0" />
                            <Vertex pos="1 -6 -1" />
                            <Vertex pos="-1 6 1" />
                            <Vertex pos="-1 6 2.38419e-007" />
                            <Vertex pos="-1 -6 1" />
                            <Vertex pos="-1 -6 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_stripe_caution1" texgens="0 1 1 3200 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.447214" album="" material="bm_friction_grass" texgens="1 0 0 -768 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.447213" album="" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-5 15 9" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 15 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 3" />
                            <Vertex pos="1 3 -3" />
                            <Vertex pos="1 -3 3" />
                            <Vertex pos="1 -3 -3" />
                            <Vertex pos="-1 3 3" />
                            <Vertex pos="-1 3 -3" />
                            <Vertex pos="-1 -3 3" />
                            <Vertex pos="-1 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -384 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-5 22 11" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 22 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 1" />
                            <Vertex pos="1 4 -1" />
                            <Vertex pos="1 -4 1" />
                            <Vertex pos="1 -4 -1" />
                            <Vertex pos="-1 4 1" />
                            <Vertex pos="-1 4 -1" />
                            <Vertex pos="-1 -4 1" />
                            <Vertex pos="-1 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-5 30 9" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 30 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 3" />
                            <Vertex pos="1 4 -3" />
                            <Vertex pos="1 -4 3" />
                            <Vertex pos="1 -4 -3" />
                            <Vertex pos="-1 4 3" />
                            <Vertex pos="-1 4 -3" />
                            <Vertex pos="-1 -4 3" />
                            <Vertex pos="-1 -4 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-16 76 16" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 76 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_friction_bounce_med" texgens="1 0 0 0 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-16 47.75 14.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 47.75 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 16.25 0.5" />
                            <Vertex pos="6.5 16.25 -0.5" />
                            <Vertex pos="6.5 -16.25 0.5" />
                            <Vertex pos="6.5 -16.25 -0.5" />
                            <Vertex pos="-6.5 16.25 0.5" />
                            <Vertex pos="-6.5 16.25 -0.5" />
                            <Vertex pos="-6.5 -16.25 0.5" />
                            <Vertex pos="-6.5 -16.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_grid_blank3" texgens="0 1 0 2112 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -1856 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16.25" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16.25" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="0 28.25 14.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 28.25 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 16.25 0.5" />
                            <Vertex pos="6.5 16.25 -0.5" />
                            <Vertex pos="6.5 -16.25 0.5" />
                            <Vertex pos="6.5 -16.25 -0.5" />
                            <Vertex pos="-6.5 16.25 0.5" />
                            <Vertex pos="-6.5 16.25 -0.5" />
                            <Vertex pos="-6.5 -16.25 0.5" />
                            <Vertex pos="-6.5 -16.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_grid_blank3" texgens="0 1 0 2240 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -1984 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16.25" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16.25" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 -384 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 640 0 -1 0 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-8 38 14.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 38 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 6.5 0.5" />
                            <Vertex pos="1.5 6.5 -0.5" />
                            <Vertex pos="1.5 -6.5 0.5" />
                            <Vertex pos="1.5 -6.5 -0.5" />
                            <Vertex pos="-1.5 6.5 0.5" />
                            <Vertex pos="-1.5 6.5 -0.5" />
                            <Vertex pos="-1.5 -6.5 0.5" />
                            <Vertex pos="-1.5 -6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank3" texgens="0 1 0 4736 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -4480 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.5" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 896 0 -1 0 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -640 0 -1 0 -4480 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-8 38 13" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 38 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 1" />
                            <Vertex pos="2 6 -1" />
                            <Vertex pos="2 -6 1" />
                            <Vertex pos="2 -6 -1" />
                            <Vertex pos="-2 6 1" />
                            <Vertex pos="-2 6 -1" />
                            <Vertex pos="-2 -6 1" />
                            <Vertex pos="-2 -6 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 3584 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -4096 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -1024 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1024 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-16 20 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 20 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 2048 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 768 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_D" texgens="1 0 0 -512 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-40 -4.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -4.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.5" />
                            <Vertex pos="4.5 0.25 -0.5" />
                            <Vertex pos="4.5 -0.25 0.5" />
                            <Vertex pos="4.5 -0.25 -0.5" />
                            <Vertex pos="-4.5 0.25 0.5" />
                            <Vertex pos="-4.5 0.25 -0.5" />
                            <Vertex pos="-4.5 -0.25 0.5" />
                            <Vertex pos="-4.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1152 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-44.25 4 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 4 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 0.5" />
                            <Vertex pos="0.25 8 -0.5" />
                            <Vertex pos="0.25 -8 0.5" />
                            <Vertex pos="0.25 -8 -0.5" />
                            <Vertex pos="-0.25 8 0.5" />
                            <Vertex pos="-0.25 8 -0.5" />
                            <Vertex pos="-0.25 -8 0.5" />
                            <Vertex pos="-0.25 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-35.75 4 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 4 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 0.5" />
                            <Vertex pos="0.25 8 -0.5" />
                            <Vertex pos="0.25 -8 0.5" />
                            <Vertex pos="0.25 -8 -0.5" />
                            <Vertex pos="-0.25 8 0.5" />
                            <Vertex pos="-0.25 8 -0.5" />
                            <Vertex pos="-0.25 -8 0.5" />
                            <Vertex pos="-0.25 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-44.25 14 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 14 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 2 -1.5" />
                            <Vertex pos="0.25 -2 1.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 2 -1.5" />
                            <Vertex pos="-0.25 -2 1.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-35.75 14 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 14 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 2 -1.5" />
                            <Vertex pos="0.25 -2 1.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 2 -1.5" />
                            <Vertex pos="-0.25 -2 1.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-44.25 26 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 26 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.5" />
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="0.25 -2 -1.5" />
                            <Vertex pos="-0.25 2 1.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                            <Vertex pos="-0.25 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-35.75 26 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 26 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.5" />
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="0.25 -2 -1.5" />
                            <Vertex pos="-0.25 2 1.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                            <Vertex pos="-0.25 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-44.25 20 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 20 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-35.75 20 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 20 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-44.25 32 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 32 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -0.500001" />
                            <Vertex pos="0.25 2 -1.5" />
                            <Vertex pos="0.25 -2 1.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="-0.25 2 -0.500001" />
                            <Vertex pos="-0.25 2 -1.5" />
                            <Vertex pos="-0.25 -2 1.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447213" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447213" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-35.75 32 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 32 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -0.500001" />
                            <Vertex pos="0.25 2 -1.5" />
                            <Vertex pos="0.25 -2 1.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="-0.25 2 -0.500001" />
                            <Vertex pos="-0.25 2 -1.5" />
                            <Vertex pos="-0.25 -2 1.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447213" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447213" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-44.25 44 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 44 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.5" />
                            <Vertex pos="0.25 2 0.499999" />
                            <Vertex pos="0.25 -2 -0.499998" />
                            <Vertex pos="0.25 -2 -1.5" />
                            <Vertex pos="-0.25 2 1.5" />
                            <Vertex pos="-0.25 2 0.499999" />
                            <Vertex pos="-0.25 -2 -0.499998" />
                            <Vertex pos="-0.25 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-35.75 44 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 44 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.5" />
                            <Vertex pos="0.25 2 0.499999" />
                            <Vertex pos="0.25 -2 -0.499998" />
                            <Vertex pos="0.25 -2 -1.5" />
                            <Vertex pos="-0.25 2 1.5" />
                            <Vertex pos="-0.25 2 0.499999" />
                            <Vertex pos="-0.25 -2 -0.499998" />
                            <Vertex pos="-0.25 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-44.25 38 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 38 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-35.75 38 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 38 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-44.25 62 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 62 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.5" />
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="0.25 -2 -1.5" />
                            <Vertex pos="-0.25 2 1.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                            <Vertex pos="-0.25 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-35.75 62 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 62 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.5" />
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="0.25 -2 -1.5" />
                            <Vertex pos="-0.25 2 1.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                            <Vertex pos="-0.25 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-44.25 56 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 56 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-35.75 56 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 56 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-44.25 72.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -44.25 0 1 0 72.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.25 0.5" />
                            <Vertex pos="0.25 8.25 -0.5" />
                            <Vertex pos="0.25 -8.25 0.5" />
                            <Vertex pos="0.25 -8.25 -0.5" />
                            <Vertex pos="-0.25 8.25 0.5" />
                            <Vertex pos="-0.25 8.25 -0.5" />
                            <Vertex pos="-0.25 -8.25 0.5" />
                            <Vertex pos="-0.25 -8.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 4160 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -4032 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-35.75 67.75 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 67.75 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.75 0.5" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0.25 -3.75 0.5" />
                            <Vertex pos="0.25 -3.75 -0.5" />
                            <Vertex pos="-0.25 3.75 0.5" />
                            <Vertex pos="-0.25 3.75 -0.5" />
                            <Vertex pos="-0.25 -3.75 0.5" />
                            <Vertex pos="-0.25 -3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2880 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-36 80.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 80.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.5" />
                            <Vertex pos="8 0.25 -0.5" />
                            <Vertex pos="8 -0.25 0.5" />
                            <Vertex pos="8 -0.25 -0.5" />
                            <Vertex pos="-8 0.25 0.5" />
                            <Vertex pos="-8 0.25 -0.5" />
                            <Vertex pos="-8 -0.25 0.5" />
                            <Vertex pos="-8 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 2048 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-32 71.75 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 71.75 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.5" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 0.5" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 3072 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -2944 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="1" type="999" pos="-16 38 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 38 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_stripe_caution1" texgens="0 1 1 5312 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_stripe_caution1" texgens="0 -1 1 -4416 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_stripe_caution1" texgens="-1 0 1 2496 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_stripe_caution1" texgens="1 0 1 -1600 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile08_D" texgens="1 0 0 -2560 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-20.25 92.25 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -20.25 0 1 0 92.25 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.5" />
                            <Vertex pos="0.25 4.25 -0.5" />
                            <Vertex pos="0.25 -4.25 0.5" />
                            <Vertex pos="0.25 -4.25 -0.5" />
                            <Vertex pos="-0.25 4.25 0.5" />
                            <Vertex pos="-0.25 4.25 -0.5" />
                            <Vertex pos="-0.25 -4.25 0.5" />
                            <Vertex pos="-0.25 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-16 96.25 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 96.25 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.5" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 0.5" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="0 96.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 96.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.5" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 0.5" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="4.25 92.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 92.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.5" />
                            <Vertex pos="0.25 4.25 -0.5" />
                            <Vertex pos="0.25 -4.25 0.5" />
                            <Vertex pos="0.25 -4.25 -0.5" />
                            <Vertex pos="-0.25 4.25 0.5" />
                            <Vertex pos="-0.25 4.25 -0.5" />
                            <Vertex pos="-0.25 -4.25 0.5" />
                            <Vertex pos="-0.25 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3136 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="4.25 76 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 76 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="4.25 60 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 60 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3200 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="0 -6.5 15" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -6.5 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3.5 3" />
                            <Vertex pos="4 2.5 -3" />
                            <Vertex pos="4 -3.5 3" />
                            <Vertex pos="4 -3.5 -3" />
                            <Vertex pos="-4 3.5 3" />
                            <Vertex pos="-4 2.5 -3" />
                            <Vertex pos="-4 -3.5 3" />
                            <Vertex pos="-4 -3.5 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1088 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 576 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.986394 -0.164399 -2.95918" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="0 -6.5 19" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -6.5 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2.5 1" />
                            <Vertex pos="4 3.5 -1" />
                            <Vertex pos="4 -3.5 1" />
                            <Vertex pos="4 -3.5 -1" />
                            <Vertex pos="-4 2.5 1" />
                            <Vertex pos="-4 3.5 -1" />
                            <Vertex pos="-4 -3.5 1" />
                            <Vertex pos="-4 -3.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -1088 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 576 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.894427 0.447214 -2.68328" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-3.75 55.75 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 55.75 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.25 0.25 0.5" />
                            <Vertex pos="8.25 0.25 -0.5" />
                            <Vertex pos="8.25 -0.25 0.5" />
                            <Vertex pos="8.25 -0.25 -0.5" />
                            <Vertex pos="-8.25 0.25 0.5" />
                            <Vertex pos="-8.25 0.25 -0.5" />
                            <Vertex pos="-8.25 -0.25 0.5" />
                            <Vertex pos="-8.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 192 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="9" type="999" pos="-16 60 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 60 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_stripe_caution1" texgens="0 1 1 5696 0 0 -1 1984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_stripe_caution1" texgens="0 -1 1 -9664 0 0 -1 1984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_stripe_caution1" texgens="-1 0 1 64 0 0 -1 1984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_stripe_caution1" texgens="1 0 1 -4032 0 0 -1 1984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_D" texgens="1 0 0 -2560 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-16 38 -10" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 38 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 5" />
                            <Vertex pos="2 2 -5" />
                            <Vertex pos="2 -2 5" />
                            <Vertex pos="2 -2 -5" />
                            <Vertex pos="-2 2 5" />
                            <Vertex pos="-2 2 -5" />
                            <Vertex pos="-2 -2 5" />
                            <Vertex pos="-2 -2 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1536 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -3584 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_grid_blank4" texgens="1 0 0 -3584 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-16 38 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 38 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 2.5 0.5" />
                            <Vertex pos="2.5 2.5 -0.5" />
                            <Vertex pos="2.5 -2.5 0.5" />
                            <Vertex pos="2.5 -2.5 -0.5" />
                            <Vertex pos="-2.5 2.5 0.5" />
                            <Vertex pos="-2.5 2.5 -0.5" />
                            <Vertex pos="-2.5 -2.5 0.5" />
                            <Vertex pos="-2.5 -2.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_grid_blank3" texgens="0 1 0 5760 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -5504 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_grid_blank3" texgens="1 0 0 1152 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 1152 0 -1 0 -5504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -896 0 -1 0 -5504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="-16 38 -16.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 38 0 0 1 -16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 2.5 0.5" />
                            <Vertex pos="2.5 2.5 -0.5" />
                            <Vertex pos="2.5 -2.5 0.5" />
                            <Vertex pos="2.5 -2.5 -0.5" />
                            <Vertex pos="-2.5 2.5 0.5" />
                            <Vertex pos="-2.5 2.5 -0.5" />
                            <Vertex pos="-2.5 -2.5 0.5" />
                            <Vertex pos="-2.5 -2.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_grid_blank3" texgens="0 1 0 5760 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -5504 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_grid_blank3" texgens="1 0 0 1152 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 1152 0 -1 0 -5504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -896 0 -1 0 -5504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="-16 76 -60" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 76 0 0 1 -60 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="6">
                        <Vertices>
                            <Vertex pos="-9.53674e-007 0 -24" />
                            <Vertex pos="12 12 24" />
                            <Vertex pos="12 -12 24" />
                            <Vertex pos="-12 12 24" />
                            <Vertex pos="-12 -12 24" />
                        </Vertices>
                        <Face id="0" plane="0.970142 0 -0.242536 -5.82085" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="-0.970143 0 -0.242536 -5.82086" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="2" plane="0 0.970143 -0.242536 -5.82085" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="3" plane="-0 -0.970142 -0.242536 -5.82085" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 4 3 1 2" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="0 0 -60" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -60 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="6">
                        <Vertices>
                            <Vertex pos="-5.17985e-007 5.17985e-007 -24" />
                            <Vertex pos="12 12 24" />
                            <Vertex pos="12 -12 24" />
                            <Vertex pos="-12 12 24" />
                            <Vertex pos="-12 -12 24" />
                        </Vertices>
                        <Face id="0" plane="0.970142 0 -0.242536 -5.82085" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="-0.970142 0 -0.242536 -5.82086" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="2" plane="0 0.970142 -0.242536 -5.82086" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="3" plane="-0 -0.970142 -0.242536 -5.82085" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 4 3 1 2" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-20.25 20 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -20.25 0 1 0 20 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-11.75 18 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.75 0 1 0 18 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.5" />
                            <Vertex pos="0.25 6 -0.5" />
                            <Vertex pos="0.25 -6 0.5" />
                            <Vertex pos="0.25 -6 -0.5" />
                            <Vertex pos="-0.25 6 0.5" />
                            <Vertex pos="-0.25 6 -0.5" />
                            <Vertex pos="-0.25 -6 0.5" />
                            <Vertex pos="-0.25 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="-16.25 14 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -16.25 0 1 0 14 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.5" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0.5" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2560 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2432 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-18.5 15.75 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 15.75 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.5" />
                            <Vertex pos="2 0.25 -0.5" />
                            <Vertex pos="2 -0.25 0.5" />
                            <Vertex pos="2 -0.25 -0.5" />
                            <Vertex pos="-2 0.25 0.5" />
                            <Vertex pos="-2 0.25 -0.5" />
                            <Vertex pos="-2 -0.25 0.5" />
                            <Vertex pos="-2 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -2880 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-16.25 -16 -14.5" rot="1 0 0 0" scale="" transform="1 0 0 -16.25 0 1 0 -16 0 0 1 -14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="4.25 -16 -14.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 -16 0 0 1 -14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-6 -20.25 -14.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -20.25 0 0 1 -14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10.5 0.25 0.5" />
                            <Vertex pos="10.5 0.25 -0.5" />
                            <Vertex pos="10.5 -0.25 0.5" />
                            <Vertex pos="10.5 -0.25 -0.5" />
                            <Vertex pos="-10.5 0.25 0.5" />
                            <Vertex pos="-10.5 0.25 -0.5" />
                            <Vertex pos="-10.5 -0.25 0.5" />
                            <Vertex pos="-10.5 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10.5" album="" material="bm_edge_white" texgens="0 1 0 3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10.5" album="" material="bm_edge_white" texgens="0 -1 0 -2880 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 1792 0 -1 0 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -1664 0 -1 0 -2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="-8 38 18" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 38 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 3" />
                            <Vertex pos="2 2 -3" />
                            <Vertex pos="2 -2 3" />
                            <Vertex pos="2 -2 -3" />
                            <Vertex pos="-2 2 3" />
                            <Vertex pos="-2 2 -3" />
                            <Vertex pos="-2 -2 3" />
                            <Vertex pos="-2 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1536 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -3584 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -3584 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="0 18 18" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 18 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 3" />
                            <Vertex pos="2 2 -3" />
                            <Vertex pos="2 -2 3" />
                            <Vertex pos="2 -2 -3" />
                            <Vertex pos="-2 2 3" />
                            <Vertex pos="-2 2 -3" />
                            <Vertex pos="-2 -2 3" />
                            <Vertex pos="-2 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1536 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -3584 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -3584 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="-16 58 18" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 58 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 3" />
                            <Vertex pos="2 2 -3" />
                            <Vertex pos="2 -2 3" />
                            <Vertex pos="2 -2 -3" />
                            <Vertex pos="-2 2 3" />
                            <Vertex pos="-2 2 -3" />
                            <Vertex pos="-2 -2 3" />
                            <Vertex pos="-2 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1536 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -3584 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -3584 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 3072 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="-16 88.25 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 88.25 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.5" />
                            <Vertex pos="4 0.25 -0.5" />
                            <Vertex pos="4 -0.25 0.5" />
                            <Vertex pos="4 -0.25 -0.5" />
                            <Vertex pos="-4 0.25 0.5" />
                            <Vertex pos="-4 0.25 -0.5" />
                            <Vertex pos="-4 -0.25 0.5" />
                            <Vertex pos="-4 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 11296 0 0 -1 -2752 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -11296 0 0 -1 -2752 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_trim" texgens="-1 0 0 2048 0 0 -1 -2752 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_trim" texgens="1 0 0 -4096 0 0 -1 -5504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_trim" texgens="1 0 0 -2048 0 -1 0 -11296 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_trim" texgens="-1 0 0 4096 0 -1 0 -22592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="-11.875 92.25 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.875 0 1 0 92.25 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4.25 0.5" />
                            <Vertex pos="0.125 4.25 -0.5" />
                            <Vertex pos="0.125 -4.25 0.5" />
                            <Vertex pos="0.125 -4.25 -0.5" />
                            <Vertex pos="-0.125 4.25 0.5" />
                            <Vertex pos="-0.125 4.25 -0.5" />
                            <Vertex pos="-0.125 -4.25 0.5" />
                            <Vertex pos="-0.125 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 23616 0 0 -1 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -23616 0 0 -1 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_trim" texgens="-1 0 0 3040 0 0 -1 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_trim" texgens="1 0 0 -3040 0 0 -1 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_trim" texgens="1 0 0 -3040 0 -1 0 -23616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_trim" texgens="-1 0 0 3040 0 -1 0 -23616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-4.125 92.25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.125 0 1 0 92.25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4.25 0.5" />
                            <Vertex pos="0.125 4.25 -0.5" />
                            <Vertex pos="0.125 -4.25 0.5" />
                            <Vertex pos="0.125 -4.25 -0.5" />
                            <Vertex pos="-0.125 4.25 0.5" />
                            <Vertex pos="-0.125 4.25 -0.5" />
                            <Vertex pos="-0.125 -4.25 0.5" />
                            <Vertex pos="-0.125 -4.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 23616 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -23616 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_trim" texgens="-1 0 0 1056 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_trim" texgens="1 0 0 -1056 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_trim" texgens="1 0 0 -1056 0 -1 0 -23616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_trim" texgens="-1 0 0 1056 0 -1 0 -23616 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="0.25 87.875 3.5" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 87.875 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.125 0.5" />
                            <Vertex pos="4.25 0.125 -0.5" />
                            <Vertex pos="4.25 -0.125 0.5" />
                            <Vertex pos="4.25 -0.125 -0.5" />
                            <Vertex pos="-4.25 0.125 0.5" />
                            <Vertex pos="-4.25 0.125 -0.5" />
                            <Vertex pos="-4.25 -0.125 0.5" />
                            <Vertex pos="-4.25 -0.125 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_trim" texgens="0 1 0 22496 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_trim" texgens="0 -1 0 -22496 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -64 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 64 0 0 -1 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_trim" texgens="1 0 0 64 0 -1 0 -22496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_trim" texgens="-1 0 0 -64 0 -1 0 -22496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="0.25 80.125 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 80.125 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.125 0.5" />
                            <Vertex pos="4.25 0.125 -0.5" />
                            <Vertex pos="4.25 -0.125 0.5" />
                            <Vertex pos="4.25 -0.125 -0.5" />
                            <Vertex pos="-4.25 0.125 0.5" />
                            <Vertex pos="-4.25 0.125 -0.5" />
                            <Vertex pos="-4.25 -0.125 0.5" />
                            <Vertex pos="-4.25 -0.125 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_trim" texgens="0 1 0 20512 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_trim" texgens="0 -1 0 -20512 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -64 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 64 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_trim" texgens="1 0 0 64 0 -1 0 -20512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_trim" texgens="-1 0 0 -64 0 -1 0 -20512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="0.25 71.875 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 71.875 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.125 0.5" />
                            <Vertex pos="4.25 0.125 -0.5" />
                            <Vertex pos="4.25 -0.125 0.5" />
                            <Vertex pos="4.25 -0.125 -0.5" />
                            <Vertex pos="-4.25 0.125 0.5" />
                            <Vertex pos="-4.25 0.125 -0.5" />
                            <Vertex pos="-4.25 -0.125 0.5" />
                            <Vertex pos="-4.25 -0.125 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_trim" texgens="0 1 0 18400 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_trim" texgens="0 -1 0 -18400 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -64 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 64 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_trim" texgens="1 0 0 64 0 -1 0 -18400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_trim" texgens="-1 0 0 -64 0 -1 0 -18400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="0.25 64.125 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 64.125 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.25 0.125 0.5" />
                            <Vertex pos="4.25 0.125 -0.5" />
                            <Vertex pos="4.25 -0.125 0.5" />
                            <Vertex pos="4.25 -0.125 -0.5" />
                            <Vertex pos="-4.25 0.125 0.5" />
                            <Vertex pos="-4.25 0.125 -0.5" />
                            <Vertex pos="-4.25 -0.125 0.5" />
                            <Vertex pos="-4.25 -0.125 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.25" album="" material="bm_trim" texgens="0 1 0 16416 0 0 -1 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.25" album="" material="bm_trim" texgens="0 -1 0 -16416 0 0 -1 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -64 0 0 -1 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 64 0 0 -1 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_trim" texgens="1 0 0 64 0 -1 0 -16416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_trim" texgens="-1 0 0 -64 0 -1 0 -16416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-14 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_stripe_caution1" texgens="0 -1 1 -1920 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_stripe_caution1" texgens="-1 0 1 -128 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_stripe_caution1" texgens="1 0 1 -3712 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_mud" texgens="1 0 0 -3584 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-14 -8 -14.5" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -8 0 0 1 -14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_stripe_caution1" texgens="0 -1 1 -832 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_stripe_caution1" texgens="-1 0 1 -64 0 0 -1 1856 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_mud" texgens="1 0 0 -3584 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="2.38419e-007 -0.263298 4.01711" rot="1 0 0 0" scale="" transform="1 0 0 2.38419e-007 0 1 0 -0.263298 0 0 1 4.01711 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="4 -0.258799 0.0171094" />
                            <Vertex pos="4 0.263305 -0.0171094" />
                            <Vertex pos="-4 -0.258799 0.0171094" />
                            <Vertex pos="-4 0.263305 -0.0171094" />
                            <Vertex pos="4 -0.263305 -0.0171094" />
                            <Vertex pos="-4 -0.263305 -0.0171094" />
                        </Vertices>
                        <Face id="0" plane="-1.21817e-009 0.0653998 0.997859 -0.000147347" album="" material="bm_tile07_D" texgens="0 -0.965926 0.258819 63.9854 -1 0 0 1024 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -222.299 0 0 1 2.18994 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 222.297 0 0 1 2.18994 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0 -0.99144 0.13056 -0.258818" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 127.452 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.0171094" album="" material="bm_grid_blank4" texgens="0 1 0 24.9891 1 0 0 -64.6834 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="0 -0.796945 4.06816" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -0.796945 0 0 1 4.06816 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.274848 -0.0339375" />
                            <Vertex pos="4 -0.238326 0.0681562" />
                            <Vertex pos="-4 0.274848 -0.0339375" />
                            <Vertex pos="-4 -0.238326 0.0681562" />
                            <Vertex pos="4 0.270342 -0.0681562" />
                            <Vertex pos="4 -0.274848 -0.0681562" />
                            <Vertex pos="-4 0.270342 -0.0681562" />
                            <Vertex pos="-4 -0.274848 -0.0681562" />
                        </Vertices>
                        <Face id="0" plane="-0 0.195121 0.980779 -0.0203436" album="" material="bm_tile07_D" texgens="0 -0.965926 0.258819 194.715 -1 0 0 1024 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -153.992 0 0 1 8.72412 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 153.99 0 0 1 8.72412 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.99144 -0.13056 -0.276927" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.130527 -0.991445 128.071 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.965931 0.2588 -0.247846" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.130527 -0.991445 128.071 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.0681562" album="" material="bm_grid_blank4" texgens="0 1 0 32.4745 1 0 0 -65.7389 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="0 -1.34606 4.15225" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -1.34606 0 0 1 4.15225 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.310789 -0.0159373" />
                            <Vertex pos="4 -0.184664 0.15225" />
                            <Vertex pos="-4 0.310789 -0.0159373" />
                            <Vertex pos="-4 -0.184664 0.15225" />
                            <Vertex pos="4 0.274267 -0.15225" />
                            <Vertex pos="4 -0.310789 -0.15225" />
                            <Vertex pos="-4 0.274267 -0.15225" />
                            <Vertex pos="-4 -0.310789 -0.15225" />
                        </Vertices>
                        <Face id="0" plane="-0 0.321446 0.946928 -0.0848105" album="" material="bm_tile07_D" texgens="0 -0.965926 0.258819 331.254 -1 0 0 1024 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -83.7051 0 0 1 19.4883 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 83.7031 0 0 1 19.4883 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.965931 -0.2588 -0.304325" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.258821 -0.965925 130.081 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.923883 0.382675 -0.22887" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.258821 -0.965925 130.081 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.15225" album="" material="bm_grid_blank4" texgens="0 1 0 38.4847 1 0 0 -66.6852 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="0 -1.92006 4.26795" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -1.92006 0 0 1 4.26795 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.389339 0.0365477" />
                            <Vertex pos="4 -0.0799357 0.267953" />
                            <Vertex pos="-4 0.389339 0.0365477" />
                            <Vertex pos="-4 -0.0799357 0.267953" />
                            <Vertex pos="4 0.263214 -0.267953" />
                            <Vertex pos="4 -0.389339 -0.267953" />
                            <Vertex pos="-4 0.263214 -0.267953" />
                            <Vertex pos="-4 -0.389339 -0.267953" />
                        </Vertices>
                        <Face id="0" plane="-0 0.442266 0.896884 -0.20497" album="" material="bm_tile07_D" texgens="0 -0.965926 0.258819 475.759 -1 0 0 1024 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -10.2329 0 0 1 34.2979 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 10.2309 0 0 1 34.2979 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.923883 -0.382675 -0.345718" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.382685 -0.923879 133.848 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.866027 0.499997 -0.203202" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.382685 -0.923879 133.848 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.267953" album="" material="bm_grid_blank4" texgens="0 1 0 42.34 1 0 0 -67.458 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="0 -2.53466 4.4133" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -2.53466 0 0 1 4.4133 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.534658 0.12261" />
                            <Vertex pos="4 0.0996139 0.413297" />
                            <Vertex pos="-4 0.534658 0.12261" />
                            <Vertex pos="-4 0.0996139 0.413297" />
                            <Vertex pos="4 0.225255 -0.413297" />
                            <Vertex pos="4 -0.534658 -0.413297" />
                            <Vertex pos="-4 0.225255 -0.413297" />
                            <Vertex pos="-4 -0.534658 -0.413297" />
                        </Vertices>
                        <Face id="0" plane="-0 0.555571 0.831469 -0.398986" album="" material="bm_tile07_D" texgens="0 -0.707105 0.707109 72.0493 -1 0 0 1024 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 68.435 0 0 1 52.9019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -68.437 0 0 1 52.9019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.866027 -0.499997 -0.401724" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.500003 -0.866024 139.952 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.793351 0.608764 -0.172572" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.500003 -0.866024 139.952 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.413297" album="" material="bm_grid_blank4" texgens="0 1 0 43.194 1 0 0 -68.0043 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="0 -3.21752 4.5858" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.21752 0 0 1 4.5858 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.782478 0.240798" />
                            <Vertex pos="4 0.389104 0.585797" />
                            <Vertex pos="-4 0.782478 0.240798" />
                            <Vertex pos="-4 0.389104 0.585797" />
                            <Vertex pos="4 0.148205 -0.585797" />
                            <Vertex pos="4 -0.782478 -0.585797" />
                            <Vertex pos="-4 0.148205 -0.585797" />
                            <Vertex pos="-4 -0.782478 -0.585797" />
                        </Vertices>
                        <Face id="0" plane="-0 0.659367 0.751821 -0.696977" album="" material="bm_tile07_D" texgens="0 -0.707105 0.707109 221.604 -1 0 0 1024 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 155.842 0 0 1 74.9819 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -155.844 0 0 1 74.9819 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.793351 -0.608764 -0.474191" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.608764 -0.793351 149.356 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.70711 0.707103 -0.139079" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.608764 -0.793351 149.356 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.585797" album="" material="bm_grid_blank4" texgens="0 1 0 39.8573 1 0 0 -68.287 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="2.38419e-007 -3.73205 6.07995" rot="1 0 0 0" scale="" transform="1 0 0 2.38419e-007 0 1 0 -3.73205 0 0 1 6.07995 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.267953 -0.0799532" />
                            <Vertex pos="4 0.0365467 0.389329" />
                            <Vertex pos="-4 0.267953 -0.0799532" />
                            <Vertex pos="-4 0.0365467 0.389329" />
                            <Vertex pos="4 -0.267953 -0.389328" />
                            <Vertex pos="4 -0.267953 0.263205" />
                            <Vertex pos="-4 -0.267953 -0.389328" />
                            <Vertex pos="-4 -0.267953 0.263205" />
                        </Vertices>
                        <Face id="0" plane="-0 0.896886 0.442262 -0.204963" album="" material="bm_tile07_D" texgens="0 -0.258815 0.965928 36.2404 -1 0 0 1024 0 0.129408 0.125" texRot="0" texScale="0.129408 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 221.701 0 0 1 266.234 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -221.703 0 0 1 266.234 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.499963 -0.866047 -0.20321" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.866028 -0.499996 134.146 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.382674 0.923884 -0.345709" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.866028 -0.499996 134.146 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0 -1 -0 -0.267953" album="" material="bm_grid_blank4" texgens="0 0 -1 -16.8445 1 0 0 -67.4579 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="2.38419e-007 -3.84775 6.65395" rot="1 0 0 0" scale="" transform="1 0 0 2.38419e-007 0 1 0 -3.84775 0 0 1 6.65395 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.15225 -0.184671" />
                            <Vertex pos="4 -0.0159371 0.310797" />
                            <Vertex pos="-4 0.15225 -0.184671" />
                            <Vertex pos="-4 -0.0159371 0.310797" />
                            <Vertex pos="4 -0.15225 -0.310797" />
                            <Vertex pos="4 -0.15225 0.274266" />
                            <Vertex pos="-4 -0.15225 -0.310797" />
                            <Vertex pos="-4 -0.15225 0.274266" />
                        </Vertices>
                        <Face id="0" plane="-0 0.946931 0.321437 -0.0848103" album="" material="bm_tile07_D" texgens="0 -0.258815 0.965928 180.756 -1 0 0 1024 0 0.129408 0.125" texRot="0" texScale="0.129408 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 236.511 0 0 1 339.706 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -236.513 0 0 1 339.706 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.382676 -0.923883 -0.228877" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.923881 -0.38268 130.239 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.258858 0.965915 -0.304329" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.923881 -0.38268 130.239 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0 -1 -0 -0.15225" album="" material="bm_grid_blank4" texgens="0 0 -1 -13.0905 1 0 0 -66.6851 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="0 -3.93184 7.20306" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.93184 0 0 1 7.20306 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.068156 -0.238313" />
                            <Vertex pos="4 -0.0339379 0.274844" />
                            <Vertex pos="-4 0.068156 -0.238313" />
                            <Vertex pos="-4 -0.0339379 0.274844" />
                            <Vertex pos="4 -0.068156 -0.274844" />
                            <Vertex pos="4 -0.068156 0.270344" />
                            <Vertex pos="-4 -0.068156 -0.274844" />
                            <Vertex pos="-4 -0.068156 0.270344" />
                        </Vertices>
                        <Face id="0" plane="-0 0.980778 0.195128 -0.0203443" album="" material="bm_tile07_D" texgens="0 -0.258815 0.965928 317.295 -1 0 0 1024 0 0.129408 0.125" texRot="0" texScale="0.129408 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 247.275 0 0 1 409.992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -247.277 0 0 1 409.992 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.258861 -0.965915 -0.247833" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.965927 -0.258815 128.133 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.130384 0.991464 -0.276923" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.965927 -0.258815 128.133 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-0 -1 -0 -0.068156" album="" material="bm_grid_blank4" texgens="0 0 -1 -7.203 1 0 0 -65.7388 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="0 -3.98289 7.7367" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.98289 0 0 1 7.7367 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="4 0.0171092 -0.258792" />
                            <Vertex pos="4 -0.0171092 0.263293" />
                            <Vertex pos="-4 0.0171092 -0.258792" />
                            <Vertex pos="-4 -0.0171092 0.263293" />
                            <Vertex pos="4 -0.0171092 -0.263292" />
                            <Vertex pos="-4 -0.0171092 -0.263292" />
                        </Vertices>
                        <Face id="0" plane="-0 0.997859 0.0654013 -0.000147166" album="" material="bm_tile07_D" texgens="0 -0.258815 0.965928 448.014 -1 0 0 1024 0 0.129408 0.125" texRot="0" texScale="0.129408 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 253.809 0 0 1 478.297 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -253.811 0 0 1 478.297 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.130383 -0.991464 -0.258814" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.991445 -0.130523 127.462 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.0171092" album="" material="bm_grid_blank4" texgens="0 0 -1 0.143631 1 0 0 -64.6834 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="0 -3.41421 4.78248" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.41421 0 0 1 4.78248 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.585791 0.389109" />
                            <Vertex pos="-4 0.585791 0.389109" />
                            <Vertex pos="4 0.240802 0.782485" />
                            <Vertex pos="-4 0.240802 0.782485" />
                            <Vertex pos="4 -0.585791 -0.782485" />
                            <Vertex pos="-4 -0.585791 -0.782485" />
                            <Vertex pos="4 -0.58579 0.148236" />
                            <Vertex pos="-4 -0.58579 0.148236" />
                        </Vertices>
                        <Face id="0" plane="-0 0.751833 0.659354 -0.696977" album="" material="bm_tile07_D" texgens="0 -0.707105 0.707109 290.393 -1 0 0 1024 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 0.70711 -0.707103 -0.139079" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.707109 -0.707105 150.059 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 181.018 0 0 1 100.158 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -181.02 0 0 1 100.158 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 -0.608751 0.793361 -0.474205" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.707109 -0.707105 150.059 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0 -1 2.56166e-007 -0.58579" album="" material="bm_grid_blank4" texgens="0 0 -1 -14.2525 1 0 0 -68.287 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="0 -3.5867 5.46536" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.5867 0 0 1 5.46536 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.12261 0.53464" />
                            <Vertex pos="-4 0.12261 0.53464" />
                            <Vertex pos="4 0.413297 0.0996099" />
                            <Vertex pos="-4 0.413297 0.0996099" />
                            <Vertex pos="4 -0.413297 0.225265" />
                            <Vertex pos="-4 -0.413297 0.225265" />
                            <Vertex pos="4 -0.413297 -0.53464" />
                            <Vertex pos="-4 -0.413297 -0.53464" />
                        </Vertices>
                        <Face id="0" plane="0 0.831462 0.555582 -0.398982" album="" material="bm_tile07_D" texgens="0 -0.707105 0.707109 439.944 -1 0 0 1024 0 0.12941 0.125" texRot="0" texScale="0.12941 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.499963 0.866047 -0.401723" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.793355 -0.608759 140.433 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 203.097 0 0 1 187.566 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="-1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -203.099 0 0 1 187.566 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 0.608751 -0.793362 -0.172568" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -0.793355 -0.608759 140.433 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -0.413297" album="" material="bm_grid_blank4" texgens="0 0 -1 35.1875 1 0 0 67.142 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="5" type="999" pos="2.25 24 22.5" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 24 0 0 1 22.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 4 1.5" />
                            <Vertex pos="1.75 4 -0.5" />
                            <Vertex pos="1.75 2 1.5" />
                            <Vertex pos="1.75 2 -0.5" />
                            <Vertex pos="-0.25 4 1.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 2 1.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_basher_side" texgens="0 1 0 3072 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_basher_side" texgens="0 -1 0 1024 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_basher" texgens="-1 0 0 448 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="Blasted" material="bm_basher" texgens="1 0 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_basher_top" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_basher_top" texgens="-1 0 0 448 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-22 52 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 52 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="0 4 -0.25" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 -4 -0.25" />
                            <Vertex pos="0 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 13312 0 0 -1 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -13312 0 0 -1 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 5632 0 0 -1 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_wood" texgens="1 0 0 -5632 0 0 -1 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -5632 0 -1 0 -13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 5632 0 -1 0 -13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-22 52 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 52 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="0 4 -0.25" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 -4 -0.25" />
                            <Vertex pos="0 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 13312 0 0 -1 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -13312 0 0 -1 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 5632 0 0 -1 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_wood" texgens="1 0 0 -5632 0 0 -1 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -5632 0 -1 0 -13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 5632 0 -1 0 -13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-22 52 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 52 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 3" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 3.75 3" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0 4 3" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 3.75 3" />
                            <Vertex pos="0 3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 13312 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -13312 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 5632 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -5632 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -5632 0 -1 0 -13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 5632 0 -1 0 -13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-22 44.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 44.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 3" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 3.75 3" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0 4 3" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 3.75 3" />
                            <Vertex pos="0 3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 11328 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -11328 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 5632 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -5632 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -5632 0 -1 0 -11328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 5632 0 -1 0 -11328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-6 22 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 22 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="0 4 -0.25" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 -4 -0.25" />
                            <Vertex pos="0 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 1536 0 0 -1 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_wood" texgens="1 0 0 -1536 0 0 -1 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -1536 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 1536 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-6 22 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 22 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="0 4 -0.25" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 -4 -0.25" />
                            <Vertex pos="0 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 1536 0 0 -1 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_wood" texgens="1 0 0 -1536 0 0 -1 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -1536 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 1536 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-6 22 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 22 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 3" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 3.75 3" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0 4 3" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 3.75 3" />
                            <Vertex pos="0 3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 5632 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -5632 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 1536 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -1536 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -1536 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 1536 0 -1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-6 14.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 14.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 3" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 3.75 3" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0 4 3" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 3.75 3" />
                            <Vertex pos="0 3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 3648 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -3648 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 1536 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -1536 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -1536 0 -1 0 -3648 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 1536 0 -1 0 -3648 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-14.25 28.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -14.25 0 1 0 28.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 3" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 3.75 3" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0 4 3" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 3.75 3" />
                            <Vertex pos="0 3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 7232 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -7232 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 3648 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -3648 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -3648 0 -1 0 -7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 3648 0 -1 0 -7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-18 28.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 28.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 3" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 3.75 3" />
                            <Vertex pos="0.25 3.75 -0.5" />
                            <Vertex pos="0 4 3" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 3.75 3" />
                            <Vertex pos="0 3.75 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 7232 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -7232 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 4608 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -4608 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -4608 0 -1 0 -7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 4608 0 -1 0 -7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-18 28.25 7" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 28.25 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 3" />
                            <Vertex pos="4 4 2.75" />
                            <Vertex pos="4 3.75 3" />
                            <Vertex pos="4 3.75 2.75" />
                            <Vertex pos="0 4 3" />
                            <Vertex pos="0 4 2.75" />
                            <Vertex pos="0 3.75 3" />
                            <Vertex pos="0 3.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_wood" texgens="0 1 0 7232 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -7232 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 4608 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -4608 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -4608 0 -1 0 -7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 2.75" album="Blasted" material="bm_wood" texgens="-1 0 0 4608 0 -1 0 -7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-18 28.25 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 28.25 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 3" />
                            <Vertex pos="4 4 2.75" />
                            <Vertex pos="4 3.75 3" />
                            <Vertex pos="4 3.75 2.75" />
                            <Vertex pos="0 4 3" />
                            <Vertex pos="0 4 2.75" />
                            <Vertex pos="0 3.75 3" />
                            <Vertex pos="0 3.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_wood" texgens="0 1 0 7232 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_wood" texgens="0 -1 0 -7232 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_wood" texgens="-1 0 0 4608 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -4608 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -4608 0 -1 0 -7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 2.75" album="Blasted" material="bm_wood" texgens="-1 0 0 4608 0 -1 0 -7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-30 68 8" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 68 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="2 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-30 68 14" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 68 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="2 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-30 68 10" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 68 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 2 0" />
                            <Vertex pos="4 2 -4" />
                            <Vertex pos="2 4 0" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-30 62 10" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 62 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 2 0" />
                            <Vertex pos="4 2 -4" />
                            <Vertex pos="2 4 0" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-30 84 8" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 84 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="2 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-30 84 14" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 84 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="2 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-30 84 10" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 84 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 2 0" />
                            <Vertex pos="4 2 -4" />
                            <Vertex pos="2 4 0" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-30 78 10" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 78 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 2 0" />
                            <Vertex pos="4 2 -4" />
                            <Vertex pos="2 4 0" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-30 84 16" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 84 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -20 -2" />
                            <Vertex pos="4 -20 -4" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 -20 -2" />
                            <Vertex pos="2 -20 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -20" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-30 84 22" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 84 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -20 -2" />
                            <Vertex pos="4 -20 -4" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 -20 -2" />
                            <Vertex pos="2 -20 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -20" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-30 84 18" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 84 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 2 0" />
                            <Vertex pos="4 2 -4" />
                            <Vertex pos="2 4 0" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-30 62 18" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 62 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 2 0" />
                            <Vertex pos="4 2 -4" />
                            <Vertex pos="2 4 0" />
                            <Vertex pos="2 4 -4" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-30 66 10" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 66 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 0 0" />
                            <Vertex pos="4 0 -4" />
                            <Vertex pos="2.5 4 0" />
                            <Vertex pos="2.5 4 -4" />
                            <Vertex pos="2.5 0 0" />
                            <Vertex pos="2.5 0 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_glass" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-30 82 10" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 82 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 0 0" />
                            <Vertex pos="4 0 -4" />
                            <Vertex pos="2.5 4 0" />
                            <Vertex pos="2.5 4 -4" />
                            <Vertex pos="2.5 0 0" />
                            <Vertex pos="2.5 0 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_glass" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-30 82 18" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 82 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -16 0" />
                            <Vertex pos="4 -16 -4" />
                            <Vertex pos="2.5 4 0" />
                            <Vertex pos="2.5 4 -4" />
                            <Vertex pos="2.5 -16 0" />
                            <Vertex pos="2.5 -16 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_glass" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-2 76 8" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 76 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 12 4" />
                            <Vertex pos="-2 12 -4" />
                            <Vertex pos="-2 10 4" />
                            <Vertex pos="-2 10 -4" />
                            <Vertex pos="-4 12 4" />
                            <Vertex pos="-4 12 -4" />
                            <Vertex pos="-4 10 4" />
                            <Vertex pos="-4 10 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 10" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-2 62 8" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 62 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 12 4" />
                            <Vertex pos="-2 12 -4" />
                            <Vertex pos="-2 2 4" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-4 12 4" />
                            <Vertex pos="-4 12 -4" />
                            <Vertex pos="-4 2 4" />
                            <Vertex pos="-4 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-2 72 8" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 72 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 14 -2" />
                            <Vertex pos="-2 14 -4" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-4 14 -2" />
                            <Vertex pos="-4 14 -4" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-2 72 14" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 72 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 14 -2" />
                            <Vertex pos="-2 14 -4" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-4 14 -2" />
                            <Vertex pos="-4 14 -4" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-2 72 10" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 72 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.5 14 0" />
                            <Vertex pos="-2.5 14 -4" />
                            <Vertex pos="-2.5 2 0" />
                            <Vertex pos="-2.5 2 -4" />
                            <Vertex pos="-4 14 0" />
                            <Vertex pos="-4 14 -4" />
                            <Vertex pos="-4 2 0" />
                            <Vertex pos="-4 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2.5" album="Blasted" material="bm_glass" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-2 76 0" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 76 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 12 4" />
                            <Vertex pos="-2 12 -4" />
                            <Vertex pos="-2 2 4" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-4 12 4" />
                            <Vertex pos="-4 12 -4" />
                            <Vertex pos="-4 2 4" />
                            <Vertex pos="-4 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-2 64 0" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 64 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 14 -2" />
                            <Vertex pos="-2 14 -4" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-4 14 -2" />
                            <Vertex pos="-4 14 -4" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-2 64 6" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 64 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 14 -2" />
                            <Vertex pos="-2 14 -4" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-4 14 -2" />
                            <Vertex pos="-4 14 -4" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-2 64 2" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 64 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.5 14 0" />
                            <Vertex pos="-2.5 14 -4" />
                            <Vertex pos="-2.5 2 0" />
                            <Vertex pos="-2.5 2 -4" />
                            <Vertex pos="-4 14 0" />
                            <Vertex pos="-4 14 -4" />
                            <Vertex pos="-4 2 0" />
                            <Vertex pos="-4 2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2.5" album="Blasted" material="bm_glass" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-2 54 0" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 54 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 12 4" />
                            <Vertex pos="-2 12 -4" />
                            <Vertex pos="-2 10 4" />
                            <Vertex pos="-2 10 -4" />
                            <Vertex pos="-4 12 4" />
                            <Vertex pos="-4 12 -4" />
                            <Vertex pos="-4 10 4" />
                            <Vertex pos="-4 10 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 10" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="6 76 -16" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 76 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 12 12" />
                            <Vertex pos="-10 12 -20" />
                            <Vertex pos="-10 -12 12" />
                            <Vertex pos="-10 -12 -20" />
                            <Vertex pos="-12 12 12" />
                            <Vertex pos="-12 12 -20" />
                            <Vertex pos="-12 -12 12" />
                            <Vertex pos="-12 -12 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 10" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_tile07_D" texgens="1 0 0 -2560 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-14 -3 -16" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -3 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -1 8" />
                            <Vertex pos="4 -1 -20" />
                            <Vertex pos="4 -7 8" />
                            <Vertex pos="4 -7 -20" />
                            <Vertex pos="2 -1 8" />
                            <Vertex pos="2 -1 -20" />
                            <Vertex pos="2 -7 8" />
                            <Vertex pos="2 -7 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-14 3 -16" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 3 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 6" />
                            <Vertex pos="4 1 -20" />
                            <Vertex pos="4 -7 6" />
                            <Vertex pos="4 -7 -20" />
                            <Vertex pos="2 1 6" />
                            <Vertex pos="2 1 -20" />
                            <Vertex pos="2 -7 6" />
                            <Vertex pos="2 -7 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-14 11 -16" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 11 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -1 4" />
                            <Vertex pos="4 -1 -20" />
                            <Vertex pos="4 -7 4" />
                            <Vertex pos="4 -7 -20" />
                            <Vertex pos="2 -1 4" />
                            <Vertex pos="2 -1 -20" />
                            <Vertex pos="2 -7 4" />
                            <Vertex pos="2 -7 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-14 11 -16" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 11 0 0 1 -16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 20" />
                            <Vertex pos="4 1 -20" />
                            <Vertex pos="4 -1 20" />
                            <Vertex pos="4 -1 -20" />
                            <Vertex pos="2 1 20" />
                            <Vertex pos="2 1 -20" />
                            <Vertex pos="2 -1 20" />
                            <Vertex pos="2 -1 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile07_D" texgens="1 0 0 -4608 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-14 9 12" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 9 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 -8" />
                            <Vertex pos="4 1 -20" />
                            <Vertex pos="4 -5 -8" />
                            <Vertex pos="4 -5 -20" />
                            <Vertex pos="2 1 -8" />
                            <Vertex pos="2 1 -20" />
                            <Vertex pos="2 -5 -8" />
                            <Vertex pos="2 -5 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_tile07_D" texgens="1 0 0 -4608 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-14 3 12" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 3 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 -8" />
                            <Vertex pos="4 1 -18" />
                            <Vertex pos="4 -7 -8" />
                            <Vertex pos="4 -7 -18" />
                            <Vertex pos="2 1 -8" />
                            <Vertex pos="2 1 -18" />
                            <Vertex pos="2 -7 -8" />
                            <Vertex pos="2 -7 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_tile07_D" texgens="1 0 0 -4608 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-14 -3 12" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -3 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -1 -8" />
                            <Vertex pos="4 -1 -16" />
                            <Vertex pos="4 -7 -8" />
                            <Vertex pos="4 -7 -16" />
                            <Vertex pos="2 -1 -8" />
                            <Vertex pos="2 -1 -16" />
                            <Vertex pos="2 -7 -8" />
                            <Vertex pos="2 -7 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 1152 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="" material="bm_grid_blank4" texgens="0 -1 0 -1664 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 8" album="" material="bm_tile07_D" texgens="1 0 0 -4608 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-14 6 -8" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 6 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -2 0" />
                            <Vertex pos="4 -2 -4" />
                            <Vertex pos="2.5 4 0" />
                            <Vertex pos="2.5 4 -4" />
                            <Vertex pos="2.5 -2 0" />
                            <Vertex pos="2.5 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_glass" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-14 0 -6" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 0 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -4 0" />
                            <Vertex pos="4 -4 -4" />
                            <Vertex pos="2.5 4 0" />
                            <Vertex pos="2.5 4 -4" />
                            <Vertex pos="2.5 -4 0" />
                            <Vertex pos="2.5 -4 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_glass" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-14 -8 -4" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -8 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0" />
                            <Vertex pos="4 4 -4" />
                            <Vertex pos="4 -2 0" />
                            <Vertex pos="4 -2 -4" />
                            <Vertex pos="2.5 4 0" />
                            <Vertex pos="2.5 4 -4" />
                            <Vertex pos="2.5 -2 0" />
                            <Vertex pos="2.5 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_glass" texgens="0 -1 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_grid_blank4" texgens="1 0 0 -1280 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="4" type="4" pos="-19 35 7" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 35 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 7 -2.5" />
                            <Vertex pos="7 7 -3" />
                            <Vertex pos="7 -1 -2.5" />
                            <Vertex pos="7 -1 -3" />
                            <Vertex pos="-1 7 -2.5" />
                            <Vertex pos="-1 7 -3" />
                            <Vertex pos="-1 -1 -2.5" />
                            <Vertex pos="-1 -1 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank4" texgens="0 1 0 -1408 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 0 -1 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2.5" album="" material="bm_grid_blank4" texgens="1 0 0 -896 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="12" type="4" pos="-12 60 -14.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 60 0 0 1 -14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 4 0" />
                            <Vertex pos="0 4 -0.5" />
                            <Vertex pos="0 -4 0" />
                            <Vertex pos="0 -4 -0.5" />
                            <Vertex pos="-8 4 0" />
                            <Vertex pos="-8 4 -0.5" />
                            <Vertex pos="-8 -4 0" />
                            <Vertex pos="-8 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_trim" texgens="0 -1 0 -7680 0 0 -1 1984 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1024 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_tile06_D" texgens="1 0 0 0 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
